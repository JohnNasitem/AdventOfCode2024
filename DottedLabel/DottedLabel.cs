using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace DottedLabel
{
    public class DottedLabel : Label
    {
        public DottedLabel()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Set up the pen for the dotted border
            using (Pen dottedPen = new Pen(Color.Black))
            {
                dottedPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

                // Adjust the rectangle to ensure the border fits within the control
                Rectangle borderRectangle = new Rectangle(0, 0, this.Width - 1, this.Height - 1);

                // Draw the dotted border
                e.Graphics.DrawRectangle(dottedPen, borderRectangle);
            }
        }
    }
}
