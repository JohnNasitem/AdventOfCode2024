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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
//given up on part 2

namespace Day6_GuardGallivant
{
    public partial class GuardGallivant : Form
    {
        HashSet<Movement> visitedPositions;
        List<List<MapObjects>> map;
        CDrawer canvas = null;
        bool outOfBounds;


        List<Movement> trail = null;
        HashSet<Movement> intersections = null;

        public GuardGallivant()
        {
            InitializeComponent();
        }

        private void UI_DragDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();        //Get dropped file name
            Stopwatch stopwatch = new Stopwatch();                                          //Measure how long it takes to get the output
            visitedPositions = new HashSet<Movement>();
            outOfBounds = false;

            intersections = new HashSet<Movement>();
            trail = new List<Movement>();

            Movement guardMovement = new Movement();

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

            //canvas = new CDrawer(fileContents.Length * 20, fileContents.Length * 20, false);
            //canvas.Scale = 20;

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
                        GuardDirection direction = new GuardDirection();

                        switch (mapObject)
                        {
                            case '<':
                                direction = GuardDirection.Left;
                                break;

                            case '>':
                                direction = GuardDirection.Right;
                                break;

                            case '^':
                                direction = GuardDirection.Up;
                                break;

                            case 'v':
                                direction = GuardDirection.Down;
                                break;
                        }

                        extractedLine.Add(MapObjects.Guard);
                        guardMovement = new Movement(new Point(x, y), direction);
                    }
                    else if (mapObject == '#')
                        extractedLine.Add(MapObjects.Obstruction);
                    else if (mapObject == '.')
                        extractedLine.Add(MapObjects.Air);

                }

                map.Add(extractedLine);
            }

            trail.Add(guardMovement);
            //Calculate path
            do
            {
                guardMovement = MoveGuard(guardMovement);
                if (UI_WatchPathCalulcation_Cbx.Checked)
                    System.Threading.Thread.Sleep(1);
            }
            while (!outOfBounds);

            stopwatch.Stop();

            Render();

            //Output values
            UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
            UI_VisitedPositionsCount_Tbx.Text = visitedPositions.Count.ToString();
            UI_LoopCount_Tbx.Text = intersections.Count.ToString();
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

        private Movement MoveGuard(Movement oldGuardMovement)
        {
            Movement guardMovement = new Movement(oldGuardMovement);
            Point nextPoint = NextPosition(guardMovement);
            bool justTurned = false;

            if (IsGuardOutOfBounds(nextPoint))
            {
                visitedPositions.Add(guardMovement);
                outOfBounds = true;
            }
            

            //Check if there is an obstance in front of guard
            //Check twice in case there are 2 obstances diagonal to each other
            for (int i = 0; i < 2 && !outOfBounds; i++)
            {
                if (map[nextPoint.Y][nextPoint.X] == MapObjects.Obstruction)
                {
                    //Change guard direction to 90 degrees
                    //Enums are ordered in a way that if current direction is up, next direction in the enum is 90 degress
                    guardMovement.Direction = (GuardDirection)(((int)guardMovement.Direction + 1) % 4);
                    nextPoint = NextPosition(guardMovement);
                    justTurned = true;
                }
            }

            Console.WriteLine($"Current Pos: {guardMovement.Position}, Current Direction: {guardMovement.Direction}, 90 from current direction: {(GuardDirection)(((int)guardMovement.Direction + 1) % 4)}");
            if (trail.Contains(guardMovement))
            {
                GuardDirection tempDirection = (GuardDirection)(((int)guardMovement.Direction - 1 + 4) % 4);
                if (intersections.Add(new Movement(guardMovement.Position, tempDirection)))
                {
                    int intersectIndex = trail.FindIndex(m => m.Equals(guardMovement));
                    List<Movement> loopPath = trail.GetRange(intersectIndex, trail.Count - intersectIndex - 1);
                    for (int i = 0; i < loopPath.Count; i++)
                    {
                        map[loopPath[i].Position.Y][loopPath[i].Position.X] = MapObjects.Loop;
                    }
                }
            }
            else if (!justTurned && PotentialLoop(guardMovement))
            {
                GuardDirection tempDirection = (GuardDirection)(((int)guardMovement.Direction - 1 + 4) % 4);
                intersections.Add(new Movement(guardMovement.Position, tempDirection));
            }

            map[guardMovement.Position.Y][guardMovement.Position.X] = MapObjects.Visited;
            if (!outOfBounds)
                map[nextPoint.Y][nextPoint.X] = MapObjects.Guard;

            visitedPositions.Add(guardMovement);
            trail.Add(guardMovement);

            if (UI_WatchPathCalulcation_Cbx.Checked)
                Render();

            guardMovement.Position = nextPoint;
            return guardMovement;
        }

        private bool IsGuardOutOfBounds(Point guardPos)
        {
            if (guardPos.X < 0 || guardPos.Y < 0 || guardPos.X >= map[0].Count || guardPos.Y >= map.Count)
                return true;

            return false;
        }

        private Point NextPosition(Movement movement)
        {
            Point pos = movement.Position;

            switch (movement.Direction)
            {
                case GuardDirection.Left:
                    pos.X--;
                    break;

                case GuardDirection.Right:
                    pos.X++;
                    break;

                case GuardDirection.Up:
                    pos.Y--;
                    break;

                case GuardDirection.Down:
                    pos.Y++;
                    break;
            }

            return pos;
        }

        private bool PotentialLoop(Movement movement)
        {
            int difference = -1;
            Movement connection = null;

            switch (movement.Direction)
            {
                case GuardDirection.Left:
                    connection = trail.Find(m => m.Position.X == movement.Position.X && m.Position.Y < movement.Position.Y && 
                    (((int)m.Direction).Equals(((int)movement.Direction + 1) % 4) ||
                    (((int)m.Direction).Equals(((int)movement.Direction + 2) % 4) && map[m.Position.Y - 1][m.Position.X] == MapObjects.Obstruction)));

                    if (connection != null)
                    {
                        difference = movement.Position.Y - connection.Position.Y;
                    }
                    break;

                case GuardDirection.Right:
                    connection = trail.Find(m => m.Position.X == movement.Position.X && m.Position.Y > movement.Position.Y && 
                    (((int)m.Direction).Equals(((int)movement.Direction + 1) % 4) || 
                    (((int)m.Direction).Equals(((int)movement.Direction + 2) % 4) && map[m.Position.Y + 1][m.Position.X] == MapObjects.Obstruction)));

                    if (connection != null)
                    {
                        difference = connection.Position.Y - movement.Position.Y;
                    }
                    break;

                case GuardDirection.Up:
                    connection = trail.Find(m => m.Position.Y == movement.Position.Y && m.Position.X > movement.Position.X && (
                    ((int)m.Direction).Equals(((int)movement.Direction + 1) % 4) ||
                    (((int)m.Direction).Equals(((int)movement.Direction + 2) % 4) && map[m.Position.Y][m.Position.X + 1] == MapObjects.Obstruction)));

                    if (connection != null)
                    {
                        difference = connection.Position.X - movement.Position.X;
                    }
                    break;

                case GuardDirection.Down:
                    connection = trail.Find(m => m.Position.Y == movement.Position.Y && m.Position.X < movement.Position.X && (
                    ((int)m.Direction).Equals(((int)movement.Direction + 1) % 4) ||
                    (((int)m.Direction).Equals(((int)movement.Direction + 2) % 4) && map[m.Position.Y][m.Position.X - 1] == MapObjects.Obstruction)));

                    if (connection != null)
                    {
                        difference = movement.Position.X - connection.Position.X;
                    }
                    break;
            }

            if (difference == -1)
                return false;

            for (int i = 0; i < difference; i++)
            {
                switch (movement.Direction)
                {
                    case GuardDirection.Left:
                        if (map[movement.Position.Y - i][movement.Position.X] == MapObjects.Obstruction)
                            return false;
                        break;

                    case GuardDirection.Right:
                        if (map[movement.Position.Y + i][movement.Position.X] == MapObjects.Obstruction)
                            return false;
                        break;

                    case GuardDirection.Up:
                        if (map[movement.Position.Y][movement.Position.X + i] == MapObjects.Obstruction)
                            return false;
                        break;

                    case GuardDirection.Down:
                        if (map[movement.Position.Y][movement.Position.X - i] == MapObjects.Obstruction)
                            return false;
                        break;
                }
            }

            return true;
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
                            canvas.AddRectangle(x, y, 1, 1, Color.Green);
                            break;

                        case MapObjects.Visited:
                            canvas.AddRectangle(x, y, 1, 1, Color.White);
                            break;

                        case MapObjects.Obstruction:
                            canvas.AddRectangle(x, y, 1, 1, Color.Red);
                            break;

                        case MapObjects.Loop:
                            canvas.AddRectangle(x, y, 1, 1, Color.Purple);
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
            Loop,
        }

        private enum GuardDirection
        {
            Up,
            Right,
            Down,
            Left
        }

        private class Movement
        {
            public Point Position { get; set; }
            public GuardDirection Direction { get; set; }

            public Movement(Point position, GuardDirection direction)
            {
                Position = position;
                Direction = direction;
            }

            public Movement() { }

            public Movement(Movement oldMovement)
            {
                Position = oldMovement.Position;
                Direction = oldMovement.Direction;
            }

            public override bool Equals(object obj)
            {
                if (!(obj is Movement other))
                    return false;

                //Return true if this instnace turned 90 degrees has the same direction and position to the parameterized instance
                return Position.Equals(other.Position) && ((int)Direction).Equals(((int)other.Direction + 1) % 4);
            }

            public override int GetHashCode()
            {
                return 1;
            }
        }
    }
}
