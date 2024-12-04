//***********************************************************************************
//Program: RedNosedReports.cs          
//Description: Extract the reports and count how many reports are safe, 1 bad level is allowed
//Date: Dec. 1/2024
//Author: John Nasitem
//Advent of Code 2024 Challenge - Day 2
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

                //Iterate throug the reports
                //Check if each report is safe
                //Problem dampener allows for 1 unsafe level
                foreach (string report in File.ReadLines(fname))
                {
                    //Extract the levels from the report
                    List<int> levels = report.Split(' ').Select(int.Parse).ToList();

                    if (IsReportSafe(levels))
                        safeReportCount++;
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

        private bool IsReportSafe(List<int> levels, bool isAlteredLevel = false)
        {
            int previousLevel = -1;
            bool isIncreasing = true;

            for (int i = 0; i < levels.Count; i++)
            {
                int currentLevel = levels[i];
                int usedPreviousLevel = previousLevel;

                //Set up for next iteration
                previousLevel = currentLevel;

                //If its the first level in the report then skip to the next level
                if (usedPreviousLevel == -1)
                {
                    //Prep isIncreasing for the next level
                    isIncreasing = currentLevel < levels[i + 1];
                    continue;
                }

                //Check if the adjacent levels cause a problem
                //2 adjacent levels need to differ by at least 1 and at most 3, if not then its unsafe
                if (Math.Abs(currentLevel - usedPreviousLevel) > 3 || Math.Abs(currentLevel - usedPreviousLevel) == 0 ||
                    //If these 2 adjacent levels are increasing but the previous adjacents were decreasing then report is unsafe
                    (usedPreviousLevel < currentLevel && !isIncreasing) ||
                    //If these 2 adjacent levels are decreasing but the previous adjacents were increasing then report is unsafe
                    (usedPreviousLevel > currentLevel && isIncreasing))
                {
                    //If there is a second bad level then altered report is unsafe
                    if (isAlteredLevel)
                        return false;

                    //If original report has a single bad level, check all if removing the bad level would make this report safe
                    //If it does then report is safe due to Problem Dampener
                    for (int j = 0; j <= i; j++)
                    {
                        List<int> alteredLevel = new List<int>(levels);
                        alteredLevel.RemoveAt(j);

                        //O(2^N) time complexity :)
                        if (IsReportSafe(alteredLevel, true))
                            return true;
                    }

                    return false;
                }

                //If the report reached the last level without finding a fault then it is safe
                if (i == levels.Count - 1)
                    return true;
            }

            return false;
        }
    }
}
