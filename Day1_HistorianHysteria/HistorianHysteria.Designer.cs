namespace Day1_HistorianHysteria
{
    partial class HistorianHysteria
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.UI_DragDropSection_Lbl = new DottedLabel.DottedLabel();
            this.SuspendLayout();
            // 
            // UI_DragDropSection_Lbl
            // 
            this.UI_DragDropSection_Lbl.AllowDrop = true;
            this.UI_DragDropSection_Lbl.AutoSize = true;
            this.UI_DragDropSection_Lbl.Location = new System.Drawing.Point(205, 188);
            this.UI_DragDropSection_Lbl.Name = "UI_DragDropSection_Lbl";
            this.UI_DragDropSection_Lbl.Size = new System.Drawing.Size(69, 13);
            this.UI_DragDropSection_Lbl.TabIndex = 1;
            this.UI_DragDropSection_Lbl.Text = "dottedLabel1";
            // 
            // HistorianHysteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_DragDropSection_Lbl);
            this.Name = "HistorianHysteria";
            this.Text = "Historian Hysteria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private DottedLabel.DottedLabel UI_DragDropSection_Lbl;
    }
}

