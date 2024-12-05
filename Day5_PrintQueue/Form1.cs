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
    public partial class Form1 : Form
    {
        Dictionary<int, List<int>> pageOrderingRules = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void UI_DragDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();        //Get dropped file name
            Stopwatch stopwatch = new Stopwatch();           //Measure how long it takes to get the output
            int middleSum = 0;
            pageOrderingRules = new Dictionary<int, List<int>>();
            List<List<int>> pagesToUpdate = new List<List<int>>();
            List<List<int>> incorrectlyOrderedPages = new List<List<int>>();
            bool isDataOrderingRules = true;

            //try
            //{
            //    
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Failed to read file.");
            //    return;
            //}

            stopwatch.Start();

            //Extract the data
            foreach (string line in File.ReadAllLines(fname))
            {
                if (line == "")
                {
                    isDataOrderingRules = false;
                    continue;
                }

                if (isDataOrderingRules)
                {
                    int key = int.Parse(line.Split('|')[0]);
                    if (pageOrderingRules.ContainsKey(key))
                        pageOrderingRules[key].Add(int.Parse(line.Split('|')[1]));
                    else
                        pageOrderingRules.Add(key, new List<int>() { int.Parse(line.Split('|')[1]) });
                }
                else
                    pagesToUpdate.Add(line.Split(',').Select(int.Parse).ToList());
            }

            foreach (List<int> pages in pagesToUpdate)
            {
                if (ArePagesInRightOrder(pages))
                    middleSum += pages[(int)Math.Floor(pages.Count / 2.0)];
                else
                    incorrectlyOrderedPages.Add(pages);
            }

            stopwatch.Stop();

            //Output values
            UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
            UI_MiddleSum_Tbx.Text = middleSum.ToString();
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

        private bool ArePagesInRightOrder(List<int> pages)
        {
            for (int i = pages.Count - 1; i > 0; i--)
                if (pageOrderingRules[pages[i]].Intersect(pages.GetRange(0, i)).ToList().Count > 0)
                    return false;

            return true;
        }

        private List<int> OrderPages(List<int> pages)
        {
            List<int> orderedPages = new List<int>();
            List<int> tempPages;

            //iterate over each index in the orderedPages list
            //in each iteration iterate over pages and find which one is allowed to be infront of the remaining pages (ones that havent been added yet)
            //Then add that page to orderedPages and remove it from tempPages
            for (int i = 0; i < pages.Count; i++)
            {
                for (int j = 0; j < pages.Count; j++)
                {

                }
            }
        }
    }
}
