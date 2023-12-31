namespace PHR_University
{
    partial class PEmailForm
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
            this.ProfessorEmailLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProfessorEmailLabel
            // 
            this.ProfessorEmailLabel.AutoSize = true;
            this.ProfessorEmailLabel.Location = new System.Drawing.Point(361, 45);
            this.ProfessorEmailLabel.Name = "ProfessorEmailLabel";
            this.ProfessorEmailLabel.Size = new System.Drawing.Size(105, 16);
            this.ProfessorEmailLabel.TabIndex = 0;
            this.ProfessorEmailLabel.Text = "Professor Email ";
            // 
            // PEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProfessorEmailLabel);
            this.Name = "PEmailForm";
            this.Text = "PEmailForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfessorEmailLabel;
    }
}