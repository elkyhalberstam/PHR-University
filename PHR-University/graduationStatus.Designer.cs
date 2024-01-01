namespace PHR_University
{
    partial class graduationStatus
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
            this.batchStatusText = new System.Windows.Forms.TextBox();
            this.batchStatus = new System.Windows.Forms.TextBox();
            this.major = new System.Windows.Forms.TextBox();
            this.majorText = new System.Windows.Forms.TextBox();
            this.minor = new System.Windows.Forms.TextBox();
            this.minorText = new System.Windows.Forms.TextBox();
            this.credtitTotal = new System.Windows.Forms.TextBox();
            this.creditTargetText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // batchStatusText
            // 
            this.batchStatusText.Location = new System.Drawing.Point(105, 104);
            this.batchStatusText.Name = "batchStatusText";
            this.batchStatusText.Size = new System.Drawing.Size(199, 26);
            this.batchStatusText.TabIndex = 7;
            // 
            // batchStatus
            // 
            this.batchStatus.Location = new System.Drawing.Point(405, 104);
            this.batchStatus.Name = "batchStatus";
            this.batchStatus.Size = new System.Drawing.Size(262, 26);
            this.batchStatus.TabIndex = 8;
            // 
            // major
            // 
            this.major.Location = new System.Drawing.Point(405, 175);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(262, 26);
            this.major.TabIndex = 10;
            // 
            // majorText
            // 
            this.majorText.Location = new System.Drawing.Point(105, 175);
            this.majorText.Name = "majorText";
            this.majorText.Size = new System.Drawing.Size(199, 26);
            this.majorText.TabIndex = 9;
            // 
            // minor
            // 
            this.minor.Location = new System.Drawing.Point(405, 243);
            this.minor.Name = "minor";
            this.minor.Size = new System.Drawing.Size(262, 26);
            this.minor.TabIndex = 12;
            // 
            // minorText
            // 
            this.minorText.Location = new System.Drawing.Point(105, 243);
            this.minorText.Name = "minorText";
            this.minorText.Size = new System.Drawing.Size(199, 26);
            this.minorText.TabIndex = 11;
            // 
            // credtitTotal
            // 
            this.credtitTotal.Location = new System.Drawing.Point(405, 307);
            this.credtitTotal.Name = "credtitTotal";
            this.credtitTotal.Size = new System.Drawing.Size(262, 26);
            this.credtitTotal.TabIndex = 14;
            // 
            // creditTargetText
            // 
            this.creditTargetText.Location = new System.Drawing.Point(105, 307);
            this.creditTargetText.Name = "creditTargetText";
            this.creditTargetText.Size = new System.Drawing.Size(199, 26);
            this.creditTargetText.TabIndex = 13;
            // 
            // graduationStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.credtitTotal);
            this.Controls.Add(this.creditTargetText);
            this.Controls.Add(this.minor);
            this.Controls.Add(this.minorText);
            this.Controls.Add(this.major);
            this.Controls.Add(this.majorText);
            this.Controls.Add(this.batchStatus);
            this.Controls.Add(this.batchStatusText);
            this.Name = "graduationStatus";
            this.Text = "batchStatus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox batchStatusText;
        private System.Windows.Forms.TextBox batchStatus;
        private System.Windows.Forms.TextBox major;
        private System.Windows.Forms.TextBox majorText;
        private System.Windows.Forms.TextBox minor;
        private System.Windows.Forms.TextBox minorText;
        private System.Windows.Forms.TextBox credtitTotal;
        private System.Windows.Forms.TextBox creditTargetText;
    }
}