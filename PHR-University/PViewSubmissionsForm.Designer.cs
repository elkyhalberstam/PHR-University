namespace PHR_University
{
    partial class PViewSubmissionsForm
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
            this.ViewSubmissionsTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewSubmissionsTitleLabel
            // 
            this.ViewSubmissionsTitleLabel.AutoSize = true;
            this.ViewSubmissionsTitleLabel.Location = new System.Drawing.Point(330, 51);
            this.ViewSubmissionsTitleLabel.Name = "ViewSubmissionsTitleLabel";
            this.ViewSubmissionsTitleLabel.Size = new System.Drawing.Size(214, 16);
            this.ViewSubmissionsTitleLabel.TabIndex = 0;
            this.ViewSubmissionsTitleLabel.Text = "Professor View Submissions Form ";
            // 
            // PViewSubmissionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewSubmissionsTitleLabel);
            this.Name = "PViewSubmissionsForm";
            this.Text = "PViewSubmissionsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewSubmissionsTitleLabel;
    }
}