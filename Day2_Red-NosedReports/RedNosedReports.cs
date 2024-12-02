using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Day2_Red_NosedReports
{
    public partial class RedNosedReports : Form
    {
        public RedNosedReports()
        {
            InitializeComponent();
        }

        private void UI_DragDropSection_Lbl_DragDrop(object sender, DragEventArgs e)
        {
            //Extract dropped file name
            string fname = ((string[])e.Data.GetData(DataFormats.FileDrop)).First();
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
