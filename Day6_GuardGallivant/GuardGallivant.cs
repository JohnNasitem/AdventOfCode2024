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

namespace Day6_GuardGallivant
{
    public partial class GuardGallivant : Form
    {
        HashSet<Point> visitedPositions = new HashSet<Point>();
        List<List<MapObjects>> map = new List<List<MapObjects>>();

        public GuardGallivant()
        {
            InitializeComponent();
        }

        private void UI_DragDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();        //Get dropped file name
            Stopwatch stopwatch = new Stopwatch();                                          //Measure how long it takes to get the output
            int visitedPositionsCount = 0;
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

            //Extract the data
            for (int y = 0; y < fileContents.Length; y++)
            {
                string line = fileContents[y];
                List<MapObjects> extractedLine = new List<MapObjects>();

                for (int x = 0; x < line.Length; x++)
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

            visitedPositionsCount = MoveGuard(guardPosition, guardDirection);

            stopwatch.Stop();
            
            //Output values
            UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
            UI_VisitedPositionsCount_Tbx.Text = visitedPositionsCount.ToString();
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

        private int MoveGuard(Point guardPos, GuardDirection guardDir, bool OutOfBounds = false)
        {
            //Check if there is an obstance in front of guard
                //Change guard direction to 90 degrees
                    //Check again just incase if there is another obstance on his right
                //Change directions if it is


                //Move guard

                //If guard hasnt been here before (add point to hashset, true if new pos, false if old pos)
                    //Return 1 + MoveGuard(...)
                //return MoveGuard(...) 

            //If none
                //Move guard in the direction he is facing
                //If guard hasnt been here before (add point to hashset, true if new pos, false if old pos)
                    //Return 1 + MoveGuard(...)
                //return MoveGuard(...) 
        }

        private bool IsGuardOutOfBounds(Point guardPos)
        {
            if (guardPos.X < 0 || guardPos.Y < 0 || guardPos.X >= map[0].Count || guardPos.Y >= map.Count)
                return true;

            return false;
        }

        private enum MapObjects
        {
            Guard,
            Obstruction,
            Air
        }

        private enum GuardDirection
        {
            Up,
            Down,
            Left,
            Right
        }
    }
}
