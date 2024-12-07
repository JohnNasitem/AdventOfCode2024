using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using GDIDrawer;

namespace Day6_GuardGallivant
{
    public partial class GuardGallivant : Form
    {
        HashSet<Point> visitedPositions = new HashSet<Point>();
        List<List<MapObjects>> map;
        CDrawer canvas = null;
        bool outOfBounds = false;

        public GuardGallivant()
        {
            InitializeComponent();
        }

        private void UI_DragDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();        //Get dropped file name
            Stopwatch stopwatch = new Stopwatch();                                          //Measure how long it takes to get the output
            Point guardPosition = Point.Empty;
            GuardDirection guardDirection = new GuardDirection();

            //try
            //{

            //}
            //catch
            //{
            //    MessageBox.Show("Failed to read file.");
            //    return;
            //}

            stopwatch.Start();

            string[] fileContents = File.ReadAllLines(fname);

            //Assume a sqaure map
            if (canvas != null)
                canvas.Close();

            canvas = new CDrawer(fileContents.Length * 4, fileContents.Length * 4, false);
            canvas.Scale = 4;

            map = new List<List<MapObjects>>();

            //Extract the data
            for (int y = 0; y < fileContents.Length; y++)
            {
                string line = fileContents[y];
                List<MapObjects> extractedLine = new List<MapObjects>();

                for (int x = 0; x < fileContents[y].Length; x++)
                {
                    char mapObject = line[x];
                    if (new char[] { '<', '>', '^', 'v'}.Contains(mapObject))
                    {
                        switch (mapObject)
                        {
                            case '<':
                                guardDirection = GuardDirection.Left;
                                break;

                            case '>':
                                guardDirection = GuardDirection.Right;
                                break;

                            case '^':
                                guardDirection = GuardDirection.Up;
                                break;

                            case 'v':
                                guardDirection = GuardDirection.Down;
                                break;
                        }

                        extractedLine.Add(MapObjects.Guard);
                        guardPosition = new Point(x, y);
                    }
                    else if (mapObject == '#')
                        extractedLine.Add(MapObjects.Obstruction);
                    else if (mapObject == '.')
                        extractedLine.Add(MapObjects.Air);

                }

                map.Add(extractedLine);
            }

            //Calculate path
            do
                MoveGuard(ref guardPosition, ref guardDirection);
            while (!outOfBounds);

            stopwatch.Stop();

            Render();

            //Output values
            UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
            UI_VisitedPositionsCount_Tbx.Text = visitedPositions.Count.ToString();
        }


        /// <summary>
        /// Allow drop effect
        /// </summary>
        /// <param name="sender">Object that called the code</param>
        /// <param name="e">Event args</param>
        private void UI_DragDrop_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void MoveGuard(ref Point guardPos, ref GuardDirection guardDir)
        {
            Point nextPoint = NextPosition(guardPos, guardDir);

            if (IsGuardOutOfBounds(nextPoint))
            {
                visitedPositions.Add(guardPos);
                outOfBounds = true;
                return;
            }

            //Check if there is an obstance in front of guard
            //Check twice in case there are 2 obstances diagonal to each other
            for (int i = 0; i < 2; i++)
            {
                if (map[nextPoint.Y][nextPoint.X] == MapObjects.Obstruction)
                {
                    //Change guard direction to 90 degrees
                    //Enums are ordered in a way that if current direction is up, next direction in the enum is 90 degress
                    guardDir = (GuardDirection)(((int)guardDir + 1) % 4);
                    nextPoint = NextPosition(guardPos, guardDir);
                }
            }

            map[guardPos.Y][guardPos.X] = MapObjects.Visited;
            map[nextPoint.Y][nextPoint.X] = MapObjects.Guard;

            if (UI_WatchPathCalulcation_Cbx.Checked)
                Render();

            visitedPositions.Add(guardPos);

            guardPos = nextPoint;
            return;
        }

        private bool IsGuardOutOfBounds(Point guardPos)
        {
            if (guardPos.X < 0 || guardPos.Y < 0 || guardPos.X >= map[0].Count || guardPos.Y >= map.Count)
                return true;

            return false;
        }

        private Point NextPosition(Point currentPostion, GuardDirection direction)
        {
            switch (direction)
            {
                case GuardDirection.Left:
                    currentPostion.X--;
                    return currentPostion;

                case GuardDirection.Right:
                    currentPostion.X++;
                    return currentPostion;

                case GuardDirection.Up:
                    currentPostion.Y--;
                    return currentPostion;

                case GuardDirection.Down:
                    currentPostion.Y++;
                    return currentPostion;
            }

            //Never going to reach
            //But is needed to satify the condition of all code paths return a value
            return new Point();
        }

        private void Render()
        {
            canvas.Clear();

            for (int y = 0; y < map.Count; y++)
            {
                for (int x = 0; x < map[y].Count; x++)
                {
                    switch (map[y][x])
                    {
                        case MapObjects.Guard:
                            canvas.SetBBScaledPixel(x, y, Color.Green);
                            break;

                        case MapObjects.Visited:
                            canvas.SetBBScaledPixel(x, y, Color.White);
                            break;

                        case MapObjects.Obstruction:
                            canvas.SetBBScaledPixel(x, y, Color.Red);
                            break;
                    }
                }
            }

            canvas.Render();
        }

        private enum MapObjects
        {
            Guard,
            Obstruction,
            Air,
            Visited,
        }

        private enum GuardDirection
        {
            Up,
            Right,
            Down,
            Left
        }
    }
}
