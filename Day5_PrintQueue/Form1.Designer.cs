namespace Day5_PrintQueue
{
    partial class Form1
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
            this.UI_MiddleSumLabel_Lbl = new System.Windows.Forms.Label();
            this.UI_MiddleSum_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TimeTaken_Lbl = new System.Windows.Forms.Label();
            this.UI_IncorrectMiddleSum_Tbx = new System.Windows.Forms.TextBox();
            this.UI_IncorrectMiddleSumLabel_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DragDrop_Lbl
            // 
            this.UI_DragDrop_Lbl.AllowDrop = true;
            this.UI_DragDrop_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DragDrop_Lbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.UI_DragDrop_Lbl.Location = new System.Drawing.Point(7, 5);
            this.UI_DragDrop_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_DragDrop_Lbl.Name = "UI_DragDrop_Lbl";
            this.UI_DragDrop_Lbl.Size = new System.Drawing.Size(809, 348);
            this.UI_DragDrop_Lbl.TabIndex = 0;
            this.UI_DragDrop_Lbl.Text = "Drag and Drop Input Here";
            this.UI_DragDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DragDrop_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragDrop_Lbl_DragDrop);
            this.UI_DragDrop_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragDrop_Lbl_DragEnter);
            // 
            // UI_MiddleSumLabel_Lbl
            // 
            this.UI_MiddleSumLabel_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_MiddleSumLabel_Lbl.AutoSize = true;
            this.UI_MiddleSumLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MiddleSumLabel_Lbl.Location = new System.Drawing.Point(9, 359);
            this.UI_MiddleSumLabel_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_MiddleSumLabel_Lbl.Name = "UI_MiddleSumLabel_Lbl";
            this.UI_MiddleSumLabel_Lbl.Size = new System.Drawing.Size(105, 19);
            this.UI_MiddleSumLabel_Lbl.TabIndex = 1;
            this.UI_MiddleSumLabel_Lbl.Text = "Middle Sum:";
            // 
            // UI_MiddleSum_Tbx
            // 
            this.UI_MiddleSum_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_MiddleSum_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MiddleSum_Tbx.Location = new System.Drawing.Point(106, 355);
            this.UI_MiddleSum_Tbx.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UI_MiddleSum_Tbx.Name = "UI_MiddleSum_Tbx";
            this.UI_MiddleSum_Tbx.ReadOnly = true;
            this.UI_MiddleSum_Tbx.Size = new System.Drawing.Size(131, 27);
            this.UI_MiddleSum_Tbx.TabIndex = 2;
            // 
            // UI_TimeTaken_Lbl
            // 
            this.UI_TimeTaken_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_TimeTaken_Lbl.AutoSize = true;
            this.UI_TimeTaken_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TimeTaken_Lbl.Location = new System.Drawing.Point(556, 359);
            this.UI_TimeTaken_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_TimeTaken_Lbl.Name = "UI_TimeTaken_Lbl";
            this.UI_TimeTaken_Lbl.Size = new System.Drawing.Size(177, 19);
            this.UI_TimeTaken_Lbl.TabIndex = 3;
            this.UI_TimeTaken_Lbl.Text = "Time Taken: Unknown";
            // 
            // UI_IncorrectMiddleSum_Tbx
            // 
            this.UI_IncorrectMiddleSum_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_IncorrectMiddleSum_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_IncorrectMiddleSum_Tbx.Location = new System.Drawing.Point(421, 355);
            this.UI_IncorrectMiddleSum_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.UI_IncorrectMiddleSum_Tbx.Name = "UI_IncorrectMiddleSum_Tbx";
            this.UI_IncorrectMiddleSum_Tbx.ReadOnly = true;
            this.UI_IncorrectMiddleSum_Tbx.Size = new System.Drawing.Size(131, 27);
            this.UI_IncorrectMiddleSum_Tbx.TabIndex = 5;
            // 
            // UI_IncorrectMiddleSumLabel_Lbl
            // 
            this.UI_IncorrectMiddleSumLabel_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_IncorrectMiddleSumLabel_Lbl.AutoSize = true;
            this.UI_IncorrectMiddleSumLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_IncorrectMiddleSumLabel_Lbl.Location = new System.Drawing.Point(240, 359);
            this.UI_IncorrectMiddleSumLabel_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_IncorrectMiddleSumLabel_Lbl.Name = "UI_IncorrectMiddleSumLabel_Lbl";
            this.UI_IncorrectMiddleSumLabel_Lbl.Size = new System.Drawing.Size(177, 19);
            this.UI_IncorrectMiddleSumLabel_Lbl.TabIndex = 4;
            this.UI_IncorrectMiddleSumLabel_Lbl.Text = "Incorrect Middle Sum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 384);
            this.Controls.Add(this.UI_IncorrectMiddleSum_Tbx);
            this.Controls.Add(this.UI_IncorrectMiddleSumLabel_Lbl);
            this.Controls.Add(this.UI_TimeTaken_Lbl);
            this.Controls.Add(this.UI_MiddleSum_Tbx);
            this.Controls.Add(this.UI_MiddleSumLabel_Lbl);
            this.Controls.Add(this.UI_DragDrop_Lbl);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DottedLabel.DottedLabel UI_DragDrop_Lbl;
        private System.Windows.Forms.Label UI_MiddleSumLabel_Lbl;
        private System.Windows.Forms.TextBox UI_MiddleSum_Tbx;
        private System.Windows.Forms.Label UI_TimeTaken_Lbl;
        private System.Windows.Forms.TextBox UI_IncorrectMiddleSum_Tbx;
        private System.Windows.Forms.Label UI_IncorrectMiddleSumLabel_Lbl;
    }
}

