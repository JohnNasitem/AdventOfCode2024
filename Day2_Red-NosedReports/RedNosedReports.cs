//***********************************************************************************
//Program: HistorianHysteria.cs          
//Description: Extract the reports and count how many reports are safe
//Date: Dec. 1/2024
//Author: John Nasitem
//Advent of Code 2024 Challenge - Day 1
//https://adventofcode.com/2024/day/2
//https://adventofcode.com/2024/day/2#part2
//***********************************************************************************

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

namespace Day2_Red_NosedReports
{
    public partial class RedNosedReports : Form
    {
        public RedNosedReports()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Count how many reports are safe using these conditions
        /// Adjacent levels must differ by at least 1 and at most 3
        /// All levels must either be all increasing of all decreasing
        /// </summary>
        /// <param name="sender">Object that called the code</param>
        /// <param name="e">Event args</param>
        private void UI_DragDropSection_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            //Extract dropped file name
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            Stopwatch stopwatch = new Stopwatch();                                  //Check how long it took to get the distance
            int safeReportCount = 0;                                                //Count of safe reports

            try
            {
                stopwatch.Start();

                foreach (string report in File.ReadLines(fname))
                {
                    int previousLevel = -1;                                         //Previous level to comapare current level to
                    bool isIncreasing = true;                                       //If the previous adjacent levels were increasing or decreasing
                    string[] levels = report.Split(' ');                            //All the levels in the report

                    //Iterate over the levels making sure they are all going in the same direction and have a the correct difference between levels
                    for (int i = 0; i < levels.Length; i++)
                    {
                        int currentLevel = Convert.ToInt32(levels[i]);
                        int usedPreviousLevel = previousLevel;

                        //Set up for next level
                        previousLevel = currentLevel;

                        //If its the first level in the report then skip to the next level
                        if (usedPreviousLevel == -1)
                        {
                            //Prep isIncreasing for the next level
                            isIncreasing = currentLevel < Convert.ToInt32(levels[i + 1]);
                            continue;
                        }

                        //2 adjacent levels need to differ by at least 1 and at most 3, if not then its unsafe
                        if (Math.Abs(currentLevel - usedPreviousLevel) > 3 || Math.Abs(currentLevel - usedPreviousLevel) == 0)
                            break;

                        //If these 2 adjacent levels are increasing but the previous adjacents were decreasing then report is unsafe
                        if (usedPreviousLevel < currentLevel && !isIncreasing)
                            break;
                        //If these 2 adjacent levels are decreasing but the previous adjacents were increasing then report is unsafe
                        else if (usedPreviousLevel > currentLevel && isIncreasing)
                            break;

                        //Save adjacent direction
                        isIncreasing = usedPreviousLevel < currentLevel;

                        //If the report reached the last level without finding a fault then it is safe
                        if (i == levels.Length - 1)
                            safeReportCount++;
                    }
                }

                stopwatch.Stop();

                //Output values
                UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
                UI_SafeReportsCount_Tbx.Text = safeReportCount.ToString();
            }
            catch
            {
                MessageBox.Show("Failed to read file.");
                return;
            }
        }

        /// <summary>
        /// Allow drop effect
        /// </summary>
        /// <param name="sender">Object that called the code</param>
        /// <param name="e">Event args</param>
        private void UI_DragDropSection_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
