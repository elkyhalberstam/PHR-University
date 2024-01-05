namespace PHR_University
{
    partial class removeClass
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.semesterBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(227, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(326, 161);
            this.dataGridView1.TabIndex = 11;
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(42, 176);
            this.semesterComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(171, 21);
            this.semesterComboBox.TabIndex = 7;
            this.semesterComboBox.SelectedIndexChanged += new System.EventHandler(this.selectSemester_);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(90, 230);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(60, 25);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // semesterBox
            // 
            this.semesterBox.Location = new System.Drawing.Point(42, 151);
            this.semesterBox.Name = "semesterBox";
            this.semesterBox.Size = new System.Drawing.Size(100, 20);
            this.semesterBox.TabIndex = 12;
            this.semesterBox.Text = "Semester";
            this.semesterBox.TextChanged += new System.EventHandler(this.semesterBox_TextChanged);
            // 
            // removeClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 380);
            this.Controls.Add(this.semesterBox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.semesterComboBox);
            this.Controls.Add(this.submitButton);
            this.Name = "removeClass";
            this.Text = "removeClass";
            this.Load += new System.EventHandler(this.removeClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox semesterBox;
    }
}