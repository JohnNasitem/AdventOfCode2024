namespace Day4_CeresSearch
{
    partial class CeresSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UI_DragDrop_Lbl = new DottedLabel.DottedLabel();
            this.UI_XmaxCountLabel_Lbl = new System.Windows.Forms.Label();
            this.UI_XmasCount_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TimeTakenPart1_Lbl = new System.Windows.Forms.Label();
            this.UI_XmasCountPart2_Tbx = new System.Windows.Forms.TextBox();
            this.UI_XmasCountPart2Label_Lbl = new System.Windows.Forms.Label();
            this.UI_TimeTakenPart2_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DragDrop_Lbl
            // 
            this.UI_DragDrop_Lbl.AllowDrop = true;
            this.UI_DragDrop_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DragDrop_Lbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.UI_DragDrop_Lbl.Location = new System.Drawing.Point(12, 9);
            this.UI_DragDrop_Lbl.Name = "UI_DragDrop_Lbl";
            this.UI_DragDrop_Lbl.Size = new System.Drawing.Size(1923, 686);
            this.UI_DragDrop_Lbl.TabIndex = 0;
            this.UI_DragDrop_Lbl.Text = "Drag and Drop Input Here";
            this.UI_DragDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DragDrop_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragDrop_Lbl_DragDrop);
            this.UI_DragDrop_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragDrop_Lbl_DragEnter);
            // 
            // UI_XmaxCountLabel_Lbl
            // 
            this.UI_XmaxCountLabel_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_XmaxCountLabel_Lbl.AutoSize = true;
            this.UI_XmaxCountLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_XmaxCountLabel_Lbl.Location = new System.Drawing.Point(12, 702);
            this.UI_XmaxCountLabel_Lbl.Name = "UI_XmaxCountLabel_Lbl";
            this.UI_XmaxCountLabel_Lbl.Size = new System.Drawing.Size(193, 34);
            this.UI_XmaxCountLabel_Lbl.TabIndex = 1;
            this.UI_XmaxCountLabel_Lbl.Text = "XMAS Count:";
            // 
            // UI_XmasCount_Tbx
            // 
            this.UI_XmasCount_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_XmasCount_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_XmasCount_Tbx.Location = new System.Drawing.Point(211, 698);
            this.UI_XmasCount_Tbx.Name = "UI_XmasCount_Tbx";
            this.UI_XmasCount_Tbx.ReadOnly = true;
            this.UI_XmasCount_Tbx.Size = new System.Drawing.Size(243, 42);
            this.UI_XmasCount_Tbx.TabIndex = 2;
            // 
            // UI_TimeTakenPart1_Lbl
            // 
            this.UI_TimeTakenPart1_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_TimeTakenPart1_Lbl.AutoSize = true;
            this.UI_TimeTakenPart1_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TimeTakenPart1_Lbl.Location = new System.Drawing.Point(908, 702);
            this.UI_TimeTakenPart1_Lbl.Name = "UI_TimeTakenPart1_Lbl";
            this.UI_TimeTakenPart1_Lbl.Size = new System.Drawing.Size(405, 34);
            this.UI_TimeTakenPart1_Lbl.TabIndex = 3;
            this.UI_TimeTakenPart1_Lbl.Text = "Time Taken (Part1): Unknown";
            // 
            // UI_XmasCountPart2_Tbx
            // 
            this.UI_XmasCountPart2_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_XmasCountPart2_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_XmasCountPart2_Tbx.Location = new System.Drawing.Point(659, 698);
            this.UI_XmasCountPart2_Tbx.Name = "UI_XmasCountPart2_Tbx";
            this.UI_XmasCountPart2_Tbx.ReadOnly = true;
            this.UI_XmasCountPart2_Tbx.Size = new System.Drawing.Size(243, 42);
            this.UI_XmasCountPart2_Tbx.TabIndex = 5;
            // 
            // UI_XmasCountPart2Label_Lbl
            // 
            this.UI_XmasCountPart2Label_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_XmasCountPart2Label_Lbl.AutoSize = true;
            this.UI_XmasCountPart2Label_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_XmasCountPart2Label_Lbl.Location = new System.Drawing.Point(460, 702);
            this.UI_XmasCountPart2Label_Lbl.Name = "UI_XmasCountPart2Label_Lbl";
            this.UI_XmasCountPart2Label_Lbl.Size = new System.Drawing.Size(205, 34);
            this.UI_XmasCountPart2Label_Lbl.TabIndex = 4;
            this.UI_XmasCountPart2Label_Lbl.Text = "X-MAS Count:";
            // 
            // UI_TimeTakenPart2_Lbl
            // 
            this.UI_TimeTakenPart2_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_TimeTakenPart2_Lbl.AutoSize = true;
            this.UI_TimeTakenPart2_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TimeTakenPart2_Lbl.Location = new System.Drawing.Point(1341, 702);
            this.UI_TimeTakenPart2_Lbl.Name = "UI_TimeTakenPart2_Lbl";
            this.UI_TimeTakenPart2_Lbl.Size = new System.Drawing.Size(405, 34);
            this.UI_TimeTakenPart2_Lbl.TabIndex = 6;
            this.UI_TimeTakenPart2_Lbl.Text = "Time Taken (Part2): Unknown";
            // 
            // CeresSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1947, 753);
            this.Controls.Add(this.UI_TimeTakenPart2_Lbl);
            this.Controls.Add(this.UI_XmasCountPart2_Tbx);
            this.Controls.Add(this.UI_XmasCountPart2Label_Lbl);
            this.Controls.Add(this.UI_TimeTakenPart1_Lbl);
            this.Controls.Add(this.UI_XmasCount_Tbx);
            this.Controls.Add(this.UI_XmaxCountLabel_Lbl);
            this.Controls.Add(this.UI_DragDrop_Lbl);
            this.Name = "CeresSearch";
            this.Text = "Ceres Search";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DottedLabel.DottedLabel UI_DragDrop_Lbl;
        private System.Windows.Forms.Label UI_XmaxCountLabel_Lbl;
        private System.Windows.Forms.TextBox UI_XmasCount_Tbx;
        private System.Windows.Forms.Label UI_TimeTakenPart1_Lbl;
        private System.Windows.Forms.TextBox UI_XmasCountPart2_Tbx;
        private System.Windows.Forms.Label UI_XmasCountPart2Label_Lbl;
        private System.Windows.Forms.Label UI_TimeTakenPart2_Lbl;
    }
}

