//***********************************************************************************
//Program: CeresSearch.cs          
//Description: Extract xmas and mas in x form word search (input)
//Date: Dec. 4/2024
//Author: John Nasitem
//Advent of Code 2024 Challenge - Day 4
//https://adventofcode.com/2024/day/4
//https://adventofcode.com/2024/day/4#part2
//***********************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.IO.Ports;

namespace Day4_CeresSearch
{
    public partial class CeresSearch : Form
    {
        int wordSearchWidth, wordSearchHeight;          //Word search dimensions
        string[] chars = null;                          //Word search character



        public CeresSearch()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Wordsearch (input) contains the letters x,m,a,s
        /// Part 1: search for the word xmas and how many times it shows up
        /// Part 2: search for the words mas in an x formation
        /// eg (. is dont care)
        /// M.S
        /// .A.
        /// M.S
        /// </summary>
        /// <param name="sender">Object that called the code</param>
        /// <param name="e">Event args</param>
        private void UI_DragDrop_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();        //Get dropped file name
            Stopwatch stopwatch1 = new Stopwatch(), stopwatch2 = new Stopwatch();           //Measure how long it takes to get the output
            int xmasCount1 = 0, xmasCount2 = 0;                                             //Counts

            try
            {
                //Get char array and set word search dimentions
                chars = File.ReadAllLines(fname).ToArray();
                wordSearchWidth = chars.Length;
                wordSearchHeight = chars.Length;

                //Get and time part 1 output
                stopwatch1.Start();
                xmasCount1 = Part1();
                stopwatch1.Stop();

                //Get and time part 2 output
                stopwatch2.Start();
                xmasCount2 = Part2();
                stopwatch2.Stop();

                //Output values
                UI_TimeTakenPart1_Lbl.Text = $"Time taken: {stopwatch1.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
                UI_TimeTakenPart2_Lbl.Text = $"Time taken: {stopwatch2.ElapsedTicks * (1.0 / Stopwatch.Frequency) * 1000} ms";
                UI_XmasCount_Tbx.Text = xmasCount1.ToString();
                UI_XmasCountPart2_Tbx.Text = xmasCount2.ToString();

            }
            catch (Exception ex)
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
        /// 
        /// </summary>
        /// <param name="x">x pos of the char being checked</param>
        /// <param name="y">y pos of the char being checked</param>
        /// <returns>how many xmas words found from that position</returns>
        private int FoundXmasCountPart1(int x, int y)
        {
            int foundXmasCount = 0;

            //Check left
            if (x >= 3 && 
                DoesPositionsContainXmasPart1(new Point(x, y), new Point(x - 1, y), new Point(x - 2, y), new Point(x - 3, y)))
                foundXmasCount++;

            //Check right
            if (x <= wordSearchWidth - 4 && 
                DoesPositionsContainXmasPart1(new Point(x, y), new Point(x + 1, y), new Point(x + 2, y), new Point(x + 3, y)))
                foundXmasCount++;

            //Check up
            if (y >= 3 &&
                DoesPositionsContainXmasPart1(new Point(x, y), new Point(x, y - 1), new Point(x, y - 2), new Point(x, y - 3)))
                foundXmasCount++;

            //Check down
            if (y <= wordSearchHeight - 4 &&
                DoesPositionsContainXmasPart1(new Point(x, y), new Point(x, y + 1), new Point(x, y + 2), new Point(x, y + 3)))
                foundXmasCount++;

            //Check top right
            if (y >= 3 && x <= wordSearchWidth - 4 &&
                DoesPositionsContainXmasPart1(new Point(x, y), new Point(x + 1, y - 1), new Point(x + 2, y - 2), new Point(x + 3, y - 3)))
                foundXmasCount++;

            //Check top left
            if (y >= 3 && x >= 3 &&
                DoesPositionsContainXmasPart1(new Point(x, y), new Point(x - 1, y - 1), new Point(x - 2, y - 2), new Point(x - 3, y - 3)))
                foundXmasCount++;

            //Check bottom right
            if (y <= wordSearchHeight - 4 && x <= wordSearchWidth - 4 &&
                DoesPositionsContainXmasPart1(new Point(x, y), new Point(x + 1, y + 1), new Point(x + 2, y + 2), new Point(x + 3, y + 3)))
                foundXmasCount++;

            //Check bottom left
            if (y <= wordSearchHeight - 4 && x >= 3 &&
                DoesPositionsContainXmasPart1(new Point(x, y), new Point(x - 1, y + 1), new Point(x - 2, y + 2), new Point(x - 3, y + 3)))
                foundXmasCount++;

            return foundXmasCount;
        }



        /// <summary>
        /// Check the given positions to see if the chars form the word XMAS
        /// </summary>
        /// <param name="pos1">character 1</param>
        /// <param name="pos2">character 2</param>
        /// <param name="pos3">character 3</param>
        /// <param name="pos4">character 4</param>
        /// <returns>If the word is XMAS</returns>
        private bool DoesPositionsContainXmasPart1(Point pos1, Point pos2, Point pos3, Point pos4)
        {
            if (chars[pos1.X][pos1.Y] == 'X' && chars[pos2.X][pos2.Y] == 'M' && chars[pos3.X][pos3.Y] == 'A' && chars[pos4.X][pos4.Y] == 'S')
                return true;

            return false;
        }



        /// <summary>
        /// Search the word search using part 1 requirements
        /// </summary>
        /// <returns>How many xmas words found</returns>
        private int Part1()
        {
            int xmasCount = 0;

            //Iterate over all the chars
            for (int y = 0; y < wordSearchHeight; y++)
                for (int x = 0; x < wordSearchWidth; x++)
                    xmasCount += FoundXmasCountPart1(x, y);

            return xmasCount;
        }



        /// <summary>
        /// Search the word search using part 2 requirements
        /// </summary>
        /// <returns>How many x-mas words found</returns>
        private int Part2()
        {
            int xmasCount = 0;

            //Iterate over all the chars
            for (int y = 0; y < wordSearchHeight; y++)
                for (int x = 0; x < wordSearchWidth; x++)
                    if (FoundXmasCountPart2(x, y))
                        xmasCount++;

            return xmasCount;
        }



        /// <summary>
        /// Check the 4 corners characters if they make up the x-mas
        /// </summary>
        /// <param name="x">x pos of the A char</param>
        /// <param name="y">y pos of the A char</param>
        /// <returns>If x-mas is found</returns>
        private bool FoundXmasCountPart2(int x, int y)
        {
            char[] cornerChars = null;

            //If the A char is on the edge then return false
            if (x == 0 || y == 0 || x == wordSearchWidth - 1 || y == wordSearchHeight - 1)
                return false;

            //If the given char isnt A then return false
            if (chars[x][y] != 'A')
                return false;

            //Get the corner chars
            cornerChars = new char[] {
                chars[x - 1][y - 1],    //Top left
                chars[x - 1][y + 1],    //Bottom left
                chars[x + 1][y + 1],    //Bottom right
                chars[x + 1][y - 1]     //Top right
            };

            //If any of the corner chars are A or X then return false
            if (cornerChars.Contains('A') || cornerChars.Contains('X'))
                return false;

            //If the opposite corners are different chars (only M and S should be left) then condition is met and return true
            if (cornerChars[0] != cornerChars[2] && cornerChars[1] != cornerChars[3])
                return true;
            else
                return false;
        }
    }
}
