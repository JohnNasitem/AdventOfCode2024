namespace Day6_GuardGallivant
{
    partial class GuardGallivant
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
            this.UI_VisitedPositionsCountLabel_Lbl = new System.Windows.Forms.Label();
            this.UI_VisitedPositionsCount_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TimeTaken_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DragDrop_Lbl
            // 
            this.UI_DragDrop_Lbl.AllowDrop = true;
            this.UI_DragDrop_Lbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.UI_DragDrop_Lbl.Location = new System.Drawing.Point(12, 9);
            this.UI_DragDrop_Lbl.Name = "UI_DragDrop_Lbl";
            this.UI_DragDrop_Lbl.Size = new System.Drawing.Size(1718, 678);
            this.UI_DragDrop_Lbl.TabIndex = 0;
            this.UI_DragDrop_Lbl.Text = "Drag and Drop Input Here";
            this.UI_DragDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_VisitedPositionsCountLabel_Lbl
            // 
            this.UI_VisitedPositionsCountLabel_Lbl.AutoSize = true;
            this.UI_VisitedPositionsCountLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_VisitedPositionsCountLabel_Lbl.Location = new System.Drawing.Point(12, 694);
            this.UI_VisitedPositionsCountLabel_Lbl.Name = "UI_VisitedPositionsCountLabel_Lbl";
            this.UI_VisitedPositionsCountLabel_Lbl.Size = new System.Drawing.Size(318, 34);
            this.UI_VisitedPositionsCountLabel_Lbl.TabIndex = 1;
            this.UI_VisitedPositionsCountLabel_Lbl.Text = "Visited Positions Count";
            // 
            // UI_VisitedPositionsCount_Tbx
            // 
            this.UI_VisitedPositionsCount_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_VisitedPositionsCount_Tbx.Location = new System.Drawing.Point(332, 690);
            this.UI_VisitedPositionsCount_Tbx.Name = "UI_VisitedPositionsCount_Tbx";
            this.UI_VisitedPositionsCount_Tbx.ReadOnly = true;
            this.UI_VisitedPositionsCount_Tbx.Size = new System.Drawing.Size(284, 42);
            this.UI_VisitedPositionsCount_Tbx.TabIndex = 2;
            // 
            // UI_TimeTaken_Lbl
            // 
            this.UI_TimeTaken_Lbl.AutoSize = true;
            this.UI_TimeTaken_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TimeTaken_Lbl.Location = new System.Drawing.Point(622, 694);
            this.UI_TimeTaken_Lbl.Name = "UI_TimeTaken_Lbl";
            this.UI_TimeTaken_Lbl.Size = new System.Drawing.Size(308, 34);
            this.UI_TimeTaken_Lbl.TabIndex = 3;
            this.UI_TimeTaken_Lbl.Text = "Time Taken: Unknown";
            // 
            // GuardGallivant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1742, 744);
            this.Controls.Add(this.UI_TimeTaken_Lbl);
            this.Controls.Add(this.UI_VisitedPositionsCount_Tbx);
            this.Controls.Add(this.UI_VisitedPositionsCountLabel_Lbl);
            this.Controls.Add(this.UI_DragDrop_Lbl);
            this.Name = "GuardGallivant";
            this.Text = "Guard Gallivant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DottedLabel.DottedLabel UI_DragDrop_Lbl;
        private System.Windows.Forms.Label UI_VisitedPositionsCountLabel_Lbl;
        private System.Windows.Forms.TextBox UI_VisitedPositionsCount_Tbx;
        private System.Windows.Forms.Label UI_TimeTaken_Lbl;
    }
}

