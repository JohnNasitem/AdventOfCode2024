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
            this.UI_WatchPath_Lbl = new System.Windows.Forms.Label();
            this.UI_WatchPathCalulcation_Cbx = new System.Windows.Forms.CheckBox();
            this.UI_LoopCount_Tbx = new System.Windows.Forms.TextBox();
            this.UI_LoopCountLabel_Lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UI_DragDrop_Lbl
            // 
            this.UI_DragDrop_Lbl.AllowDrop = true;
            this.UI_DragDrop_Lbl.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.UI_DragDrop_Lbl.Location = new System.Drawing.Point(7, 5);
            this.UI_DragDrop_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_DragDrop_Lbl.Name = "UI_DragDrop_Lbl";
            this.UI_DragDrop_Lbl.Size = new System.Drawing.Size(1188, 367);
            this.UI_DragDrop_Lbl.TabIndex = 0;
            this.UI_DragDrop_Lbl.Text = "Drag and Drop Input Here";
            this.UI_DragDrop_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UI_DragDrop_Lbl.DragDrop += new System.Windows.Forms.DragEventHandler(this.UI_DragDrop_Lbl_DragDrop);
            this.UI_DragDrop_Lbl.DragEnter += new System.Windows.Forms.DragEventHandler(this.UI_DragDrop_Lbl_DragEnter);
            // 
            // UI_VisitedPositionsCountLabel_Lbl
            // 
            this.UI_VisitedPositionsCountLabel_Lbl.AutoSize = true;
            this.UI_VisitedPositionsCountLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_VisitedPositionsCountLabel_Lbl.Location = new System.Drawing.Point(7, 378);
            this.UI_VisitedPositionsCountLabel_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_VisitedPositionsCountLabel_Lbl.Name = "UI_VisitedPositionsCountLabel_Lbl";
            this.UI_VisitedPositionsCountLabel_Lbl.Size = new System.Drawing.Size(180, 19);
            this.UI_VisitedPositionsCountLabel_Lbl.TabIndex = 1;
            this.UI_VisitedPositionsCountLabel_Lbl.Text = "Visited Positions Count:";
            // 
            // UI_VisitedPositionsCount_Tbx
            // 
            this.UI_VisitedPositionsCount_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_VisitedPositionsCount_Tbx.Location = new System.Drawing.Point(183, 374);
            this.UI_VisitedPositionsCount_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.UI_VisitedPositionsCount_Tbx.Name = "UI_VisitedPositionsCount_Tbx";
            this.UI_VisitedPositionsCount_Tbx.ReadOnly = true;
            this.UI_VisitedPositionsCount_Tbx.Size = new System.Drawing.Size(157, 27);
            this.UI_VisitedPositionsCount_Tbx.TabIndex = 2;
            // 
            // UI_TimeTaken_Lbl
            // 
            this.UI_TimeTaken_Lbl.AutoSize = true;
            this.UI_TimeTaken_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_TimeTaken_Lbl.Location = new System.Drawing.Point(610, 378);
            this.UI_TimeTaken_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_TimeTaken_Lbl.Name = "UI_TimeTaken_Lbl";
            this.UI_TimeTaken_Lbl.Size = new System.Drawing.Size(177, 19);
            this.UI_TimeTaken_Lbl.TabIndex = 3;
            this.UI_TimeTaken_Lbl.Text = "Time Taken: Unknown";
            // 
            // UI_WatchPath_Lbl
            // 
            this.UI_WatchPath_Lbl.AutoSize = true;
            this.UI_WatchPath_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_WatchPath_Lbl.Location = new System.Drawing.Point(572, 377);
            this.UI_WatchPath_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_WatchPath_Lbl.Name = "UI_WatchPath_Lbl";
            this.UI_WatchPath_Lbl.Size = new System.Drawing.Size(0, 19);
            this.UI_WatchPath_Lbl.TabIndex = 4;
            // 
            // UI_WatchPathCalulcation_Cbx
            // 
            this.UI_WatchPathCalulcation_Cbx.AutoSize = true;
            this.UI_WatchPathCalulcation_Cbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_WatchPathCalulcation_Cbx.Location = new System.Drawing.Point(996, 376);
            this.UI_WatchPathCalulcation_Cbx.Name = "UI_WatchPathCalulcation_Cbx";
            this.UI_WatchPathCalulcation_Cbx.Size = new System.Drawing.Size(199, 23);
            this.UI_WatchPathCalulcation_Cbx.TabIndex = 5;
            this.UI_WatchPathCalulcation_Cbx.Text = "Watch Path Calulation";
            this.UI_WatchPathCalulcation_Cbx.UseVisualStyleBackColor = true;
            // 
            // UI_LoopCount_Tbx
            // 
            this.UI_LoopCount_Tbx.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LoopCount_Tbx.Location = new System.Drawing.Point(449, 374);
            this.UI_LoopCount_Tbx.Margin = new System.Windows.Forms.Padding(2);
            this.UI_LoopCount_Tbx.Name = "UI_LoopCount_Tbx";
            this.UI_LoopCount_Tbx.ReadOnly = true;
            this.UI_LoopCount_Tbx.Size = new System.Drawing.Size(157, 27);
            this.UI_LoopCount_Tbx.TabIndex = 7;
            // 
            // UI_LoopCountLabel_Lbl
            // 
            this.UI_LoopCountLabel_Lbl.AutoSize = true;
            this.UI_LoopCountLabel_Lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UI_LoopCountLabel_Lbl.Location = new System.Drawing.Point(344, 378);
            this.UI_LoopCountLabel_Lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UI_LoopCountLabel_Lbl.Name = "UI_LoopCountLabel_Lbl";
            this.UI_LoopCountLabel_Lbl.Size = new System.Drawing.Size(101, 19);
            this.UI_LoopCountLabel_Lbl.TabIndex = 6;
            this.UI_LoopCountLabel_Lbl.Text = "Loop Count:";
            // 
            // GuardGallivant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 403);
            this.Controls.Add(this.UI_LoopCount_Tbx);
            this.Controls.Add(this.UI_LoopCountLabel_Lbl);
            this.Controls.Add(this.UI_WatchPathCalulcation_Cbx);
            this.Controls.Add(this.UI_WatchPath_Lbl);
            this.Controls.Add(this.UI_TimeTaken_Lbl);
            this.Controls.Add(this.UI_VisitedPositionsCount_Tbx);
            this.Controls.Add(this.UI_VisitedPositionsCountLabel_Lbl);
            this.Controls.Add(this.UI_DragDrop_Lbl);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label UI_WatchPath_Lbl;
        private System.Windows.Forms.CheckBox UI_WatchPathCalulcation_Cbx;
        private System.Windows.Forms.TextBox UI_LoopCount_Tbx;
        private System.Windows.Forms.Label UI_LoopCountLabel_Lbl;
    }
}

