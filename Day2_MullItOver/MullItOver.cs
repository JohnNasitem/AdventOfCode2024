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
using System.Text.RegularExpressions;

namespace Day2_MullItOver
{
    public partial class MullItOver : Form
    {
        public MullItOver()
        {
            InitializeComponent();
        }

        private void UI_DragDropSection_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
            Stopwatch stopwatch = new Stopwatch();
            int mulTotal = 0;

            try
            {
                File.ReadAllText(fname);

                foreach (Match match in Regex.Matches(File.ReadAllText(fname), @"mul\(\d{1,3},\d{1,3}\)"))
                {
                    Console.WriteLine(match);
                }
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
