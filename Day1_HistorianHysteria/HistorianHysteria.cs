//***********************************************************************************
//Program: HistorianHysteria.cs          
//Description: Extract two lists from the input and get the total distance between the two lists
//Date: Dec. 1/2024
//Author: John Nasitem
//Advent of Code 2024 Challenge - Day 1
//https://adventofcode.com/2024/day/1
//https://adventofcode.com/2024/day/1#part2
//***********************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Day1_HistorianHysteria
{
    public partial class HistorianHysteria : Form
    {
        //Defining varaibles
        List<int> leftList = new List<int>();               //To compare with right list and get the distance between
        List<int> rightList = new List<int>();              //To compare with left list and get the distance between
        Stopwatch stopwatch = new Stopwatch();              //Check how long it took to get the distance



        /// <summary>
        /// Initializes a new instance of the HistorianHysteria class
        /// </summary>
        public HistorianHysteria()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Extract the two lists from a text file and get the total distance between the lists
        /// </summary>
        /// <param name="sender">Object that called the code</param>
        /// <param name="e">Event args</param>
        private void UI_DragDropSection_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            //Extract dropped file name
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            int totalDistance = 0;                                                          //Total distance between the 2 lists
            int similarityScore = 0;                                                        //Similarity score between the two lists
            Dictionary<int, int> rightListOccurances = new Dictionary<int, int>();          //How often each right list value appears in the right list
            HashSet<int> rightListUniqueValues = new HashSet<int>();                        //Unique right list values

            //Reset previous runs
            stopwatch.Reset();
            leftList.Clear();
            rightList.Clear();

            try
            {
                stopwatch.Start();

                //Extract list values
                foreach (string line in File.ReadAllLines(fname))
                {
                    int rightListValue = Convert.ToInt32(line.Split(' ')[3]);
                    leftList.Add(Convert.ToInt32(line.Split(' ')[0]));
                    rightList.Add(rightListValue);

                    //Get the count of all the right list value occurances
                    if (rightListUniqueValues.Add(rightListValue))
                        rightListOccurances.Add(rightListValue, 1);
                    else
                        rightListOccurances[rightListValue]++;
                }

                leftList.Sort();
                rightList.Sort();

                //Compare lowest values from each list list then seconding lowest and so on
                for (int i = 0; i < leftList.Count; i++)
                {
                    totalDistance += Math.Abs(leftList[i] - rightList[i]);
                    
                    if (rightListOccurances.ContainsKey(leftList[i]))
                        similarityScore += leftList[i] * rightListOccurances[leftList[i]];
                }

                stopwatch.Stop();

                //Output values
                UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
                UI_TotalDistance_Tbx.Text = totalDistance.ToString();
                UI_SimilarityScore_Tbx.Text = similarityScore.ToString();

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
