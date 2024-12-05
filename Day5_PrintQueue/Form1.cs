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

            foreach (List<int> page in pagesToUpdate)
                if (IsUpdateInRightOrder(page))
                    middleSum += page[(int)Math.Floor(page.Count / 2.0)];


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

        private bool IsUpdateInRightOrder(List<int> update)
        {
            for (int i = update.Count - 1; i > 0; i--)
                if (pageOrderingRules[update[i]].Intersect(update.GetRange(0, i)).ToList().Count > 0)
                    return false;

            return true;
        }
    }
}
