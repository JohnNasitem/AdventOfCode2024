//***********************************************************************************
//Program: PrintQueue.cs          
//Description: Extract the page ordering rules as well as the pages to produce in each update (input)
//             Return the sum of the middle values in each pages to produce that are in the right order and a separate sum for the ones no in the right order
//Date: Dec. 5/2024
//Author: John Nasitem
//Advent of Code 2024 Challenge - Day 5
//https://adventofcode.com/2024/day/5
//https://adventofcode.com/2024/day/5#part2
//***********************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Day5_PrintQueue
{
    public partial class PrintQueue : Form
    {
        Dictionary<int, List<int>> pageOrderingRules = null;            //Ordering rules

        public PrintQueue()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Sum the middle values in each of the pages to update, use seperate sums for correctly ordered pages and incorrectly ordered pages that were sorted
        /// </summary>
        /// <param name="sender">Object that called the code</param>
        /// <param name="e">Event args</param>
        private void UI_DragDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();        //Get dropped file name
            Stopwatch stopwatch = new Stopwatch();                                          //Measure how long it takes to get the output
            int middleSum = 0, incorrectMiddleSum = 0;                                      //Sums for both in order pages and not in order pages
            pageOrderingRules = new Dictionary<int, List<int>>();                           //Ordering rules
            List<List<int>> pagesToUpdate = new List<List<int>>();                          //Extracted list of pages to update
            bool isDataOrderingRules = true;                                                //Flag to determine what value is being extracted

            try
            {
                stopwatch.Start();

                //Extract the data
                foreach (string line in File.ReadAllLines(fname))
                {
                    //If the line is empty then switch to extracting pages
                    if (line == "")
                    {
                        isDataOrderingRules = false;
                        continue;
                    }

                    if (isDataOrderingRules)
                    {
                        int key = int.Parse(line.Split('|')[0]);

                        //If the key doesnt exist yet in the dictionary then create one, if it does then add it to the keys values
                        if (pageOrderingRules.ContainsKey(key))
                            pageOrderingRules[key].Add(int.Parse(line.Split('|')[1]));
                        else
                            pageOrderingRules.Add(key, new List<int>() { int.Parse(line.Split('|')[1]) });
                    }
                    else
                        pagesToUpdate.Add(line.Split(',').Select(int.Parse).ToList());
                }



                //Iterate through the list of pages to update
                //Accumulate the sums for the correctly ordered pages
                //And sort then accumalte to sums for incorrected ordered pages
                foreach (List<int> pages in pagesToUpdate)
                {
                    if (ArePagesInRightOrder(pages))
                        middleSum += pages[(int)Math.Floor(pages.Count / 2.0)];
                    else
                        incorrectMiddleSum += OrderPages(pages)[(int)Math.Floor(pages.Count / 2.0)];
                }

                stopwatch.Stop();

                //Output values
                UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
                UI_MiddleSum_Tbx.Text = middleSum.ToString();
                UI_IncorrectMiddleSum_Tbx.Text = incorrectMiddleSum.ToString();
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
        private void UI_DragDrop_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }



        /// <summary>
        /// Check if the list of pages are in correct order acorrding to the page ordering rules
        /// </summary>
        /// <param name="pages">Pages to check</param>
        /// <returns></returns>
        private bool ArePagesInRightOrder(List<int> pages)
        {
            //Start iterating from the back (stop at the second first index because first doesnt need to be checked as nothing is infront of it)
            //Check each value if the values before it are allowed to be before it using the page ordering rules
            //Values in the page ordering rules are numbers that are supposed to be before the number being checked
            for (int i = pages.Count - 1; i > 0; i--)
                if (pageOrderingRules[pages[i]].Intersect(pages.GetRange(0, i)).ToList().Count > 0)
                    return false;

            return true;
        }



        /// <summary>
        /// Sort the pages to conform to the page ordering rules
        /// </summary>
        /// <param name="pages">Pages to order</param>
        /// <returns></returns>
        private List<int> OrderPages(List<int> pages)
        {
            List<int> orderedPages = new List<int>();           //Sorted pages
            List<int> availablePages = new List<int>(pages);    //Pages left to the sorted

            //iterate over each index in the orderedPages list
            //in each iteration, iterate over pages and find which one is allowed to be infront of the remaining pages (ones that havent been added yet)
            //Then add that page to orderedPages and remove it from avaliable pages
            for (int i = 0; i < pages.Count; i++)
                for (int j = 0; j < availablePages.Count; j++)
                    if (pageOrderingRules[availablePages[j]].Intersect(availablePages.GetRange(j + 1, availablePages.Count - j - 1)).ToList().Count == 0)
                    {
                        orderedPages.Add(availablePages[j]);
                        availablePages.RemoveAt(j);
                        break;
                    }

            return orderedPages;
        }
    }
}
