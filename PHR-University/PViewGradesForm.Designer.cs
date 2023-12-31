namespace PHR_University
{
    partial class PViewGradesForm
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
            this.ViewGradesTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewGradesTitleLabel
            // 
            this.ViewGradesTitleLabel.AutoSize = true;
            this.ViewGradesTitleLabel.Location = new System.Drawing.Point(335, 56);
            this.ViewGradesTitleLabel.Name = "ViewGradesTitleLabel";
            this.ViewGradesTitleLabel.Size = new System.Drawing.Size(179, 16);
            this.ViewGradesTitleLabel.TabIndex = 0;
            this.ViewGradesTitleLabel.Text = "Professor View Grades Form";
            // 
            // PViewGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewGradesTitleLabel);
            this.Name = "PViewGradesForm";
            this.Text = "PViewGradesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewGradesTitleLabel;
    }
}