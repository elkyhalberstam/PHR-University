namespace PHR_University
{
    partial class PAcademicSchedForm
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
            this.AcademicScheduleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AcademicScheduleLabel
            // 
            this.AcademicScheduleLabel.AutoSize = true;
            this.AcademicScheduleLabel.Location = new System.Drawing.Point(331, 44);
            this.AcademicScheduleLabel.Name = "AcademicScheduleLabel";
            this.AcademicScheduleLabel.Size = new System.Drawing.Size(162, 16);
            this.AcademicScheduleLabel.TabIndex = 0;
            this.AcademicScheduleLabel.Text = "Academic Schedule Form";
            // 
            // AcademicSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AcademicScheduleLabel);
            this.Name = "AcademicSchedule";
            this.Text = "AcademicSchedule";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AcademicScheduleLabel;
    }
}