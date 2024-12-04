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
        private DomainUpDown domainUpDown1;

        public DottedLabel()
        {
            this.SetStyle(ControlStyles.UserPaint | ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            this.AllowDrop = true;
            this.Font = new Font("Century Gothic", 20, FontStyle.Bold);
            this.Location = new Point(12, 9);
            this.TextAlign = ContentAlignment.MiddleCenter;
            this.Text = "Drag and Drop Input Here";
            this.AutoSize = false;
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

        private void InitializeComponent()
        {
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.SuspendLayout();
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(0, 0);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(120, 29);
            this.domainUpDown1.TabIndex = 0;
            this.domainUpDown1.Text = "domainUpDown1";
            this.ResumeLayout(false);
        }
    }
}
