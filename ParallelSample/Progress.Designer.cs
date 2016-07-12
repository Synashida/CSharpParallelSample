namespace StringBuilderSample
{
    partial class Progress
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
            this.pgbMain = new System.Windows.Forms.ProgressBar();
            this.pgbInFunction = new System.Windows.Forms.ProgressBar();
            this.lblMain = new System.Windows.Forms.Label();
            this.lblInFunction = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pgbMain
            // 
            this.pgbMain.Location = new System.Drawing.Point(15, 28);
            this.pgbMain.Name = "pgbMain";
            this.pgbMain.Size = new System.Drawing.Size(461, 23);
            this.pgbMain.TabIndex = 0;
            // 
            // pgbInFunction
            // 
            this.pgbInFunction.Location = new System.Drawing.Point(15, 66);
            this.pgbInFunction.Name = "pgbInFunction";
            this.pgbInFunction.Size = new System.Drawing.Size(461, 23);
            this.pgbInFunction.TabIndex = 1;
            // 
            // lblMain
            // 
            this.lblMain.AutoSize = true;
            this.lblMain.Location = new System.Drawing.Point(213, 33);
            this.lblMain.Name = "lblMain";
            this.lblMain.Size = new System.Drawing.Size(51, 12);
            this.lblMain.TabIndex = 2;
            this.lblMain.Text = "Main 0/3";
            // 
            // lblInFunction
            // 
            this.lblInFunction.AutoSize = true;
            this.lblInFunction.Location = new System.Drawing.Point(189, 72);
            this.lblInFunction.Name = "lblInFunction";
            this.lblInFunction.Size = new System.Drawing.Size(108, 12);
            this.lblInFunction.TabIndex = 3;
            this.lblInFunction.Text = "In Function 0/25000";
            // 
            // Progress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 119);
            this.ControlBox = false;
            this.Controls.Add(this.lblInFunction);
            this.Controls.Add(this.lblMain);
            this.Controls.Add(this.pgbInFunction);
            this.Controls.Add(this.pgbMain);
            this.Name = "Progress";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Progress_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pgbMain;
        private System.Windows.Forms.ProgressBar pgbInFunction;
        private System.Windows.Forms.Label lblMain;
        private System.Windows.Forms.Label lblInFunction;
    }
}