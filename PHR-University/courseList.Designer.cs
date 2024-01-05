namespace PHR_University
{
    partial class courseList
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
            this.semesterComboBox = new System.Windows.Forms.ComboBox();
            this.semesterBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // semesterComboBox
            // 
            this.semesterComboBox.FormattingEnabled = true;
            this.semesterComboBox.Location = new System.Drawing.Point(55, 91);
            this.semesterComboBox.Name = "semesterComboBox";
            this.semesterComboBox.Size = new System.Drawing.Size(121, 21);
            this.semesterComboBox.TabIndex = 0;
            this.semesterComboBox.SelectedIndexChanged += new System.EventHandler(this.semesterComboBox_SelectedIndexChanged);
            // 
            // semesterBox
            // 
            this.semesterBox.Location = new System.Drawing.Point(56, 65);
            this.semesterBox.Name = "semesterBox";
            this.semesterBox.Size = new System.Drawing.Size(100, 20);
            this.semesterBox.TabIndex = 1;
            this.semesterBox.Text = "Semester";
            this.semesterBox.TextChanged += new System.EventHandler(this.semesterTextBox);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleName = "semesterGridView";
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(39, 173);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(710, 150);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // courseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 400);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.semesterBox);
            this.Controls.Add(this.semesterComboBox);
            this.Name = "courseList";
            this.Text = "courseList";
            this.Load += new System.EventHandler(this.courseList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox semesterComboBox;
        private System.Windows.Forms.TextBox semesterBox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}