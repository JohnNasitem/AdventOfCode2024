namespace Day2_Red_NosedReports
{
    partial class RedNosedReports
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
            this.UI_DragDropSection_Lbl = new DottedLabel.DottedLabel();
            this.UI_SafeReportCountLabel_Lbl = new System.Windows.Forms.Label();
            this.UI_SafeReportsCount_Tbx = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UI_DragDropSection_Lbl
            // 
            this.UI_DragDropSection_Lbl.AllowDrop = true;
            this.UI_DragDropSection_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UI_DragDropSection_Lbl.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UI_DragDropSection_Lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_DragDropSection_Lbl.Location = new System.Drawing.Point(12, 9);
            this.UI_DragDropSection_Lbl.Name = "UI_DragDropSection_Lbl";
            this.UI_DragDropSection_Lbl.Size = new System.Drawing.Size(776, 406);
            this.UI_DragDropSection_Lbl.TabIndex = 0;
            this.UI_DragDropSection_Lbl.Text = "Drag and Drop Input Here";
            this.UI_DragDropSection_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UI_SafeReportCountLabel_Lbl
            // 
            this.UI_SafeReportCountLabel_Lbl.AutoSize = true;
            this.UI_SafeReportCountLabel_Lbl.BackColor = System.Drawing.SystemColors.Control;
            this.UI_SafeReportCountLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SafeReportCountLabel_Lbl.Location = new System.Drawing.Point(12, 422);
            this.UI_SafeReportCountLabel_Lbl.Name = "UI_SafeReportCountLabel_Lbl";
            this.UI_SafeReportCountLabel_Lbl.Size = new System.Drawing.Size(155, 19);
            this.UI_SafeReportCountLabel_Lbl.TabIndex = 1;
            this.UI_SafeReportCountLabel_Lbl.Text = "Safe Reports Count:";
            // 
            // UI_SafeReportsCount_Tbx
            // 
            this.UI_SafeReportsCount_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SafeReportsCount_Tbx.Location = new System.Drawing.Point(173, 418);
            this.UI_SafeReportsCount_Tbx.Name = "UI_SafeReportsCount_Tbx";
            this.UI_SafeReportsCount_Tbx.ReadOnly = true;
            this.UI_SafeReportsCount_Tbx.Size = new System.Drawing.Size(123, 27);
            this.UI_SafeReportsCount_Tbx.TabIndex = 2;
            // 
            // RedNosedReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_SafeReportsCount_Tbx);
            this.Controls.Add(this.UI_SafeReportCountLabel_Lbl);
            this.Controls.Add(this.UI_DragDropSection_Lbl);
            this.Name = "RedNosedReports";
            this.Text = "Red-Nosed Reports";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DottedLabel.DottedLabel UI_DragDropSection_Lbl;
        private System.Windows.Forms.Label UI_SafeReportCountLabel_Lbl;
        private System.Windows.Forms.TextBox UI_SafeReportsCount_Tbx;
    }
}

