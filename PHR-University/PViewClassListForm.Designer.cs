namespace PHR_University
{
    partial class PViewClassListForm
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
            this.ViewClassListTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ViewClassListTitleLabel
            // 
            this.ViewClassListTitleLabel.AutoSize = true;
            this.ViewClassListTitleLabel.Location = new System.Drawing.Point(324, 40);
            this.ViewClassListTitleLabel.Name = "ViewClassListTitleLabel";
            this.ViewClassListTitleLabel.Size = new System.Drawing.Size(194, 16);
            this.ViewClassListTitleLabel.TabIndex = 0;
            this.ViewClassListTitleLabel.Text = "Professor View Class List Form ";
            // 
            // PViewClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewClassListTitleLabel);
            this.Name = "PViewClassListForm";
            this.Text = "PViewClassListForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewClassListTitleLabel;
    }
}