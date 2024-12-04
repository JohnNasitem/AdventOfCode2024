namespace Day3_MullItOver
{
    partial class MullItOver
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
            this.UI_MulTotalLabel_Lbl = new System.Windows.Forms.Label();
            this.UI_MulTotal_Tbx = new System.Windows.Forms.TextBox();
            this.UI_TimeTaken_Lbl = new System.Windows.Forms.Label();
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
            this.UI_DragDropSection_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragDropSection_Lbl_DragDrop);
            this.UI_DragDropSection_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragDropSection_Lbl_DragEnter);
            // 
            // UI_MulTotalLabel_Lbl
            // 
            this.UI_MulTotalLabel_Lbl.AutoSize = true;
            this.UI_MulTotalLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MulTotalLabel_Lbl.Location = new System.Drawing.Point(12, 422);
            this.UI_MulTotalLabel_Lbl.Name = "UI_MulTotalLabel_Lbl";
            this.UI_MulTotalLabel_Lbl.Size = new System.Drawing.Size(81, 19);
            this.UI_MulTotalLabel_Lbl.TabIndex = 1;
            this.UI_MulTotalLabel_Lbl.Text = "Mul Total:";
            // 
            // UI_MulTotal_Tbx
            // 
            this.UI_MulTotal_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_MulTotal_Tbx.Location = new System.Drawing.Point(102, 418);
            this.UI_MulTotal_Tbx.Name = "UI_MulTotal_Tbx";
            this.UI_MulTotal_Tbx.ReadOnly = true;
            this.UI_MulTotal_Tbx.Size = new System.Drawing.Size(144, 27);
            this.UI_MulTotal_Tbx.TabIndex = 2;
            // 
            // UI_TimeTaken_Lbl
            // 
            this.UI_TimeTaken_Lbl.AutoSize = true;
            this.UI_TimeTaken_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TimeTaken_Lbl.Location = new System.Drawing.Point(252, 422);
            this.UI_TimeTaken_Lbl.Name = "UI_TimeTaken_Lbl";
            this.UI_TimeTaken_Lbl.Size = new System.Drawing.Size(177, 19);
            this.UI_TimeTaken_Lbl.TabIndex = 3;
            this.UI_TimeTaken_Lbl.Text = "Time Taken: Unknown";
            // 
            // MullItOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UI_TimeTaken_Lbl);
            this.Controls.Add(this.UI_MulTotal_Tbx);
            this.Controls.Add(this.UI_MulTotalLabel_Lbl);
            this.Controls.Add(this.UI_DragDropSection_Lbl);
            this.Name = "MullItOver";
            this.Text = "Mull It Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DottedLabel.DottedLabel UI_DragDropSection_Lbl;
        private System.Windows.Forms.Label UI_MulTotalLabel_Lbl;
        private System.Windows.Forms.TextBox UI_MulTotal_Tbx;
        private System.Windows.Forms.Label UI_TimeTaken_Lbl;
    }
}

