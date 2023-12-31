namespace PHR_University
{
    partial class PEnterGradesForm
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
            this.EnterGradesTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EnterGradesTitleLabel
            // 
            this.EnterGradesTitleLabel.AutoSize = true;
            this.EnterGradesTitleLabel.Location = new System.Drawing.Point(305, 40);
            this.EnterGradesTitleLabel.Name = "EnterGradesTitleLabel";
            this.EnterGradesTitleLabel.Size = new System.Drawing.Size(181, 16);
            this.EnterGradesTitleLabel.TabIndex = 0;
            this.EnterGradesTitleLabel.Text = "Professor Enter Grades Form";
            // 
            // PEnterGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EnterGradesTitleLabel);
            this.Name = "PEnterGradesForm";
            this.Text = "PEnterGradesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterGradesTitleLabel;
    }
}