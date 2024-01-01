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
            this.EmailGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EmailGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProfessorEmailLabel
            // 
            this.ProfessorEmailLabel.AutoSize = true;
            this.ProfessorEmailLabel.Location = new System.Drawing.Point(271, 37);
            this.ProfessorEmailLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProfessorEmailLabel.Name = "ProfessorEmailLabel";
            this.ProfessorEmailLabel.Size = new System.Drawing.Size(97, 15);
            this.ProfessorEmailLabel.TabIndex = 0;
            this.ProfessorEmailLabel.Text = "Professor Email ";
            // 
            // EmailGridView
            // 
            this.EmailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EmailGridView.Location = new System.Drawing.Point(54, 90);
            this.EmailGridView.Name = "EmailGridView";
            this.EmailGridView.RowHeadersWidth = 51;
            this.EmailGridView.Size = new System.Drawing.Size(506, 73);
            this.EmailGridView.TabIndex = 1;
            // 
            // PEmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.EmailGridView);
            this.Controls.Add(this.ProfessorEmailLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PEmailForm";
            this.Text = "PEmailForm";
            ((System.ComponentModel.ISupportInitialize)(this.EmailGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProfessorEmailLabel;
        private System.Windows.Forms.DataGridView EmailGridView;
    }
}