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
        List<int> leftList = new List<int>();
        List<int> rightList = new List<int>();
        Stopwatch stopwatch = new Stopwatch();

        public HistorianHysteria()
        {
            InitializeComponent();
        }

        private void UI_DragDropSection_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            long totalDistance = 0;
            stopwatch.Restart();

            try
            {
                stopwatch.Start();

                foreach (string line in File.ReadAllLines(fname))
                {
                    leftList.Add(Convert.ToInt32(line.Split(' ')[0]));
                    rightList.Add(Convert.ToInt32(line.Split(' ')[3]));
                }

                leftList.Sort();
                rightList.Sort();

                for (int i = 0; i < leftList.Count; i++)
                    totalDistance += Math.Abs(leftList[i] - rightList[i]);

                stopwatch.Stop();

                UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedMilliseconds} ms";
                UI_Output_Tbx.Text = totalDistance.ToString();

            }
            catch
            {
                MessageBox.Show("Failed to read file.");
                return;
            }
        }

        private void UI_DragDropSection_Lbl_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }
    }
}
