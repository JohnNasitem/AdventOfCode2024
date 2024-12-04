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
            this.UI_XmasCount_Lbl = new System.Windows.Forms.TextBox();
            this.UI_TimeTaken_Lbl = new System.Windows.Forms.Label();
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
            this.UI_DragDrop_Lbl.Size = new System.Drawing.Size(1324, 686);
            this.UI_DragDrop_Lbl.TabIndex = 0;
            this.UI_DragDrop_Lbl.Text = "Drag and Drop Input Here";
            this.UI_DragDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // UI_XmasCount_Lbl
            // 
            this.UI_XmasCount_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_XmasCount_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_XmasCount_Lbl.Location = new System.Drawing.Point(211, 698);
            this.UI_XmasCount_Lbl.Name = "UI_XmasCount_Lbl";
            this.UI_XmasCount_Lbl.ReadOnly = true;
            this.UI_XmasCount_Lbl.Size = new System.Drawing.Size(243, 42);
            this.UI_XmasCount_Lbl.TabIndex = 2;
            // 
            // UI_TimeTaken_Lbl
            // 
            this.UI_TimeTaken_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_TimeTaken_Lbl.AutoSize = true;
            this.UI_TimeTaken_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TimeTaken_Lbl.Location = new System.Drawing.Point(460, 702);
            this.UI_TimeTaken_Lbl.Name = "UI_TimeTaken_Lbl";
            this.UI_TimeTaken_Lbl.Size = new System.Drawing.Size(308, 34);
            this.UI_TimeTaken_Lbl.TabIndex = 3;
            this.UI_TimeTaken_Lbl.Text = "Time Taken: Unknown";
            // 
            // CeresSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 753);
            this.Controls.Add(this.UI_TimeTaken_Lbl);
            this.Controls.Add(this.UI_XmasCount_Lbl);
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
        private System.Windows.Forms.TextBox UI_XmasCount_Lbl;
        private System.Windows.Forms.Label UI_TimeTaken_Lbl;
    }
}

