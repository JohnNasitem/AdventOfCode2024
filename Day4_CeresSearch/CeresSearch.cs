using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Day4_CeresSearch
{
    public partial class CeresSearch : Form
    {
        int wordSearchWidth, wordSearchHeight;
        string[] chars = null;

        public CeresSearch()
        {
            InitializeComponent();
        }

        private void UI_DragDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();        //Get dropped file name
            Stopwatch stopwatch = new Stopwatch();                                          //Measure how long it takes to get the output
            int xmasCount = 0;

            try
            {
                stopwatch.Start();

                chars = File.ReadAllLines(fname).ToArray();

                wordSearchWidth = chars.Length;
                wordSearchHeight = chars.Length;

                for (int y = 0; y < wordSearchHeight; y++)
                    for (int x = 0; x < wordSearchWidth; x++)
                        xmasCount += FoundXmasCount(x, y);

                stopwatch.Stop();

                //Output values
                UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
                UI_XmasCount_Tbx.Text = xmasCount.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to read file.");
                Console.WriteLine(ex.Message + "-" + ex.StackTrace);
                return;
            }
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

        private int FoundXmasCount(int x, int y)
        {
            int foundXmasCount = 0;

            //Check left
            if (x >= 3 && 
                DoesPositionsContainXmas(new Point(x, y), new Point(x - 1, y), new Point(x - 2, y), new Point(x - 3, y)))
                foundXmasCount++;

            //Check right
            if (x <= wordSearchWidth - 4 && 
                DoesPositionsContainXmas(new Point(x, y), new Point(x + 1, y), new Point(x + 2, y), new Point(x + 3, y)))
                foundXmasCount++;

            //Check up
            if (y >= 3 &&
                DoesPositionsContainXmas(new Point(x, y), new Point(x, y - 1), new Point(x, y - 2), new Point(x, y - 3)))
                foundXmasCount++;

            //Check down
            if (y <= wordSearchHeight - 4 &&
                DoesPositionsContainXmas(new Point(x, y), new Point(x, y + 1), new Point(x, y + 2), new Point(x, y + 3)))
                foundXmasCount++;

            //Check top right
            if (y >= 3 && x <= wordSearchWidth - 4 &&
                DoesPositionsContainXmas(new Point(x, y), new Point(x + 1, y - 1), new Point(x + 2, y - 2), new Point(x + 3, y - 3)))
                foundXmasCount++;

            //Check top left
            if (y >= 3 && x >= 3 &&
                DoesPositionsContainXmas(new Point(x, y), new Point(x - 1, y - 1), new Point(x - 2, y - 2), new Point(x - 3, y - 3)))
                foundXmasCount++;

            //Check bottom right
            if (y <= wordSearchHeight - 4 && x <= wordSearchWidth - 4 &&
                DoesPositionsContainXmas(new Point(x, y), new Point(x + 1, y + 1), new Point(x + 2, y + 2), new Point(x + 3, y + 3)))
                foundXmasCount++;

            //Check bottom left
            if (y <= wordSearchHeight - 4 && x >= 3 &&
                DoesPositionsContainXmas(new Point(x, y), new Point(x - 1, y + 1), new Point(x - 2, y + 2), new Point(x - 3, y + 3)))
                foundXmasCount++;

            return foundXmasCount;
        }

        private bool DoesPositionsContainXmas(Point pos1, Point pos2, Point pos3, Point pos4)
        {
            if (chars[pos1.X][pos1.Y] == 'X' && chars[pos2.X][pos2.Y] == 'M' && chars[pos3.X][pos3.Y] == 'A' && chars[pos4.X][pos4.Y] == 'S')
                return true;

            return false;
        }
    }
}
