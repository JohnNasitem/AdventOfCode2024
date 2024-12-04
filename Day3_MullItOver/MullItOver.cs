//***********************************************************************************
//Program: MullItOver.cs          
//Description: Extract working code from program (input)
//Date: Dec. 3/2024
//Author: John Nasitem
//Advent of Code 2024 Challenge - Day 3
//https://adventofcode.com/2024/day/3
//https://adventofcode.com/2024/day/3#part2
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
using System.Text.RegularExpressions;

namespace Day3_MullItOver
{
    public partial class MullItOver : Form
    {
        public MullItOver()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Program (input) contains mul(), do(), and don't() commands
        /// Extract the intact commands and get the output
        /// </summary>
        /// <param name="sender">Object that called the code</param>
        /// <param name="e">Event args</param>
        private void UI_DragDropSection_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();        //Get dropped file name
            Stopwatch stopwatch = new Stopwatch();                                          //Measure how long it takes to get the output
            int mulTotal = 0;                                                               //Output
            bool doMul = true;                                                              //Was last command do() or don't()

            try
            {
                stopwatch.Start();

                //Go over program and extract the intact mul(), do(), and don't commands
                //Add the mul() output to the total if the more recent command was do()
                foreach (Match match in Regex.Matches(File.ReadAllText(fname), @"mul\(\d{1,3},\d{1,3}\)|do\(\)|don't\(\)"))
                {
                    int[] numbers = new int[2];         //2 numbers in the mul() command
                    int i = 0;                          //Increment var

                    //Update the most recent command
                    if (match.Value == "do()")
                        doMul = true;
                    else if (match.Value == "don't()")
                        doMul = false;
                    //Get the numbers inside of mul()
                    else
                        foreach (Match num in Regex.Matches(match.Value, @"\d{1,3}"))
                            numbers[i++] = int.Parse(num.Value);

                    //If last command is do() then add the mul() output to the total
                    if (doMul)
                        mulTotal += numbers[0] * numbers[1];
                }

                stopwatch.Stop();

                //Output values
                UI_TimeTaken_Lbl.Text = $"Time taken: {stopwatch.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
                UI_MulTotal_Tbx.Text = mulTotal.ToString();
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
