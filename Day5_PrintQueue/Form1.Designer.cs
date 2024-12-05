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
            this.UI_DragDrop_Lbl.Size = new System.Drawing.Size(1484, 643);
            this.UI_DragDrop_Lbl.TabIndex = 0;
            this.UI_DragDrop_Lbl.Text = "Drag and Drop Input Here";
            this.UI_DragDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_MiddleSumLabel_Lbl
            // 
            this.UI_MiddleSumLabel_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_MiddleSumLabel_Lbl.AutoSize = true;
            this.UI_MiddleSumLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MiddleSumLabel_Lbl.Location = new System.Drawing.Point(16, 659);
            this.UI_MiddleSumLabel_Lbl.Name = "UI_MiddleSumLabel_Lbl";
            this.UI_MiddleSumLabel_Lbl.Size = new System.Drawing.Size(182, 34);
            this.UI_MiddleSumLabel_Lbl.TabIndex = 1;
            this.UI_MiddleSumLabel_Lbl.Text = "Middle Sum:";
            // 
            // UI_MiddleSum_Tbx
            // 
            this.UI_MiddleSum_Tbx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_MiddleSum_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MiddleSum_Tbx.Location = new System.Drawing.Point(195, 655);
            this.UI_MiddleSum_Tbx.Name = "UI_MiddleSum_Tbx";
            this.UI_MiddleSum_Tbx.ReadOnly = true;
            this.UI_MiddleSum_Tbx.Size = new System.Drawing.Size(236, 42);
            this.UI_MiddleSum_Tbx.TabIndex = 2;
            // 
            // UI_TimeTaken_Lbl
            // 
            this.UI_TimeTaken_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_TimeTaken_Lbl.AutoSize = true;
            this.UI_TimeTaken_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TimeTaken_Lbl.Location = new System.Drawing.Point(437, 659);
            this.UI_TimeTaken_Lbl.Name = "UI_TimeTaken_Lbl";
            this.UI_TimeTaken_Lbl.Size = new System.Drawing.Size(308, 34);
            this.UI_TimeTaken_Lbl.TabIndex = 3;
            this.UI_TimeTaken_Lbl.Text = "Time Taken: Unknown";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1508, 709);
            this.Controls.Add(this.UI_TimeTaken_Lbl);
            this.Controls.Add(this.UI_MiddleSum_Tbx);
            this.Controls.Add(this.UI_MiddleSumLabel_Lbl);
            this.Controls.Add(this.UI_DragDrop_Lbl);
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
    }
}

