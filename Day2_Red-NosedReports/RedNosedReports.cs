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
                    List<int> levels = report.Split(' ').Select(int.Parse).ToList();                           //All the levels in the report
                    bool isFirstUnsafeLevel = true;

                    Console.WriteLine("-------------------------------------------------------");
                    Console.WriteLine($"Checking Report: \t{report}");

                    //Iterate over the levels making sure they are all going in the same direction and have a the correct difference between levels
                    for (int i = 0; i < levels.Count; i++)
                    {
                        int currentLevel = levels[i];
                        int usedPreviousLevel = previousLevel;
                        bool didLevelGetRemoved  = false;

                        //Set up for next level
                        previousLevel = currentLevel;

                        //If its the first level in the report then skip to the next level
                        if (usedPreviousLevel == -1)
                        {
                            //Prep isIncreasing for the next level
                            isIncreasing = currentLevel < levels[i + 1];
                            continue;
                        }

                            //2 adjacent levels need to differ by at least 1 and at most 3, if not then its unsafe
                        if (Math.Abs(currentLevel - usedPreviousLevel) > 3 || Math.Abs(currentLevel - usedPreviousLevel) == 0 ||
                            //If these 2 adjacent levels are increasing but the previous adjacents were decreasing then report is unsafe
                            (usedPreviousLevel < currentLevel && !isIncreasing) ||
                            //If these 2 adjacent levels are decreasing but the previous adjacents were increasing then report is unsafe
                            (usedPreviousLevel > currentLevel && isIncreasing))
                        {
                            if (Math.Abs(currentLevel - usedPreviousLevel) > 3)
                            {
                                Console.WriteLine($"Error: Difference is {Math.Abs(currentLevel - usedPreviousLevel)}");
                            }
                            else if (Math.Abs(currentLevel - usedPreviousLevel) == 0)
                            {
                                Console.WriteLine($"Error: Difference is 0");
                            }
                            else if (usedPreviousLevel < currentLevel && !isIncreasing)
                            {
                                Console.WriteLine($"Error: Adjacent is increasing, but previous were decreasing");
                            }
                            else if (usedPreviousLevel > currentLevel && isIncreasing)
                            {
                                Console.WriteLine($"Error: Adjacent is decreasing, but previous were increasing");
                            }

                            if (isFirstUnsafeLevel)
                            {
                                isFirstUnsafeLevel = false;
                                Console.WriteLine($"Removing - {levels[i]}, at index {i}");
                                levels.RemoveAt(i);

                                if (i == levels.Count)
                                {
                                    i = levels.Count - 1;
                                } else
                                {
                                    if (i - 1 < 0)
                                    {
                                        i = 0;
                                    }
                                    else
                                    {
                                        i--;
                                    }

                                    previousLevel = usedPreviousLevel;
                                }
                                Console.WriteLine($"Rewound back to: {i}, after i++ its {i + 1}, new previous: {previousLevel}");
                                didLevelGetRemoved = true;
                            }
                            else
                            {
                                Console.WriteLine($"New Report: \t\t{string.Join(" ", levels)}");
                                Console.WriteLine("Safety: Unsafe");

                                //FOund 1 problem
                                //If bad level is the very first, it wont be removed causing whole report to be unsafe
                                //
                                //
                                //Find a way to either redo the entire check without the first level or idk
                                //maybe turn the check into a method
                                //
                                //
                                //
                                //
                                //
                                break;
                            }
                        }

                        //Save adjacent direction
                        if (!didLevelGetRemoved)
                            isIncreasing = usedPreviousLevel < currentLevel;

                        //If the report reached the last level without finding a fault then it is safe
                        if (i == levels.Count - 1)
                        {
                            Console.WriteLine($"New Report: \t\t{string.Join(" ", levels)}");
                            Console.WriteLine("Safety: Safe");
                            safeReportCount++;
                        }
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
