﻿namespace Day1_HistorianHysteria
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
            this.UI_OutputLabel_Lbl = new System.Windows.Forms.Label();
            this.UI_DragDropSection_Lbl = new DottedLabel.DottedLabel();
            this.UI_TotalDistance_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TimeTaken_Lbl = new System.Windows.Forms.Label();
            this.UI_SimilarityScore_Tbx = new System.Windows.Forms.TextBox();
            this.UI_SimilarityScoreLabel_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_OutputLabel_Lbl
            // 
            this.UI_OutputLabel_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_OutputLabel_Lbl.AutoSize = true;
            this.UI_OutputLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_OutputLabel_Lbl.Location = new System.Drawing.Point(12, 422);
            this.UI_OutputLabel_Lbl.Name = "UI_OutputLabel_Lbl";
            this.UI_OutputLabel_Lbl.Size = new System.Drawing.Size(119, 19);
            this.UI_OutputLabel_Lbl.TabIndex = 2;
            this.UI_OutputLabel_Lbl.Text = "Total Distance:";
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
            this.UI_DragDropSection_Lbl.TabIndex = 1;
            this.UI_DragDropSection_Lbl.Text = "Drop and Drop Input Here";
            this.UI_DragDropSection_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DragDropSection_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragDropSection_Lbl_DragDrop);
            this.UI_DragDropSection_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragDropSection_Lbl_DragEnter);
            // 
            // UI_TotalDistance_Tbx
            // 
            this.UI_TotalDistance_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TotalDistance_Tbx.Location = new System.Drawing.Point(137, 418);
            this.UI_TotalDistance_Tbx.Name = "UI_TotalDistance_Tbx";
            this.UI_TotalDistance_Tbx.ReadOnly = true;
            this.UI_TotalDistance_Tbx.Size = new System.Drawing.Size(119, 27);
            this.UI_TotalDistance_Tbx.TabIndex = 3;
            // 
            // UI_TimeTaken_Lbl
            // 
            this.UI_TimeTaken_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_TimeTaken_Lbl.AutoSize = true;
            this.UI_TimeTaken_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TimeTaken_Lbl.Location = new System.Drawing.Point(510, 422);
            this.UI_TimeTaken_Lbl.Name = "UI_TimeTaken_Lbl";
            this.UI_TimeTaken_Lbl.Size = new System.Drawing.Size(177, 19);
            this.UI_TimeTaken_Lbl.TabIndex = 4;
            this.UI_TimeTaken_Lbl.Text = "Time Taken: Unknown";
            // 
            // UI_SimilarityScore_Tbx
            // 
            this.UI_SimilarityScore_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SimilarityScore_Tbx.Location = new System.Drawing.Point(385, 418);
            this.UI_SimilarityScore_Tbx.Name = "UI_SimilarityScore_Tbx";
            this.UI_SimilarityScore_Tbx.ReadOnly = true;
            this.UI_SimilarityScore_Tbx.Size = new System.Drawing.Size(119, 27);
            this.UI_SimilarityScore_Tbx.TabIndex = 6;
            // 
            // UI_SimilarityScoreLabel_Lbl
            // 
            this.UI_SimilarityScoreLabel_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.UI_SimilarityScoreLabel_Lbl.AutoSize = true;
            this.UI_SimilarityScoreLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_SimilarityScoreLabel_Lbl.Location = new System.Drawing.Point(260, 422);
            this.UI_SimilarityScoreLabel_Lbl.Name = "UI_SimilarityScoreLabel_Lbl";
            this.UI_SimilarityScoreLabel_Lbl.Size = new System.Drawing.Size(129, 19);
            this.UI_SimilarityScoreLabel_Lbl.TabIndex = 5;
            this.UI_SimilarityScoreLabel_Lbl.Text = "Similarity Score ";
            // 
            // HistorianHysteria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_SimilarityScore_Tbx);
            this.Controls.Add(this.UI_SimilarityScoreLabel_Lbl);
            this.Controls.Add(this.UI_TimeTaken_Lbl);
            this.Controls.Add(this.UI_TotalDistance_Tbx);
            this.Controls.Add(this.UI_OutputLabel_Lbl);
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
        private System.Windows.Forms.Label UI_OutputLabel_Lbl;
        private System.Windows.Forms.TextBox UI_TotalDistance_Tbx;
        private System.Windows.Forms.Label UI_TimeTaken_Lbl;
        private System.Windows.Forms.TextBox UI_SimilarityScore_Tbx;
        private System.Windows.Forms.Label UI_SimilarityScoreLabel_Lbl;
    }
}

