namespace PHR_University
{
    partial class stdCourseSchedue
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
            this.selectedSemester = new System.Windows.Forms.TextBox();
            this.semester = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(802, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // selectedSemester
            // 
            this.selectedSemester.Location = new System.Drawing.Point(379, 13);
            this.selectedSemester.Name = "selectedSemester";
            this.selectedSemester.ReadOnly = true;
            this.selectedSemester.Size = new System.Drawing.Size(184, 26);
            this.selectedSemester.TabIndex = 1;
            // 
            // semester
            // 
            this.semester.BackColor = System.Drawing.SystemColors.Menu;
            this.semester.Location = new System.Drawing.Point(192, 13);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(150, 26);
            this.semester.TabIndex = 2;
            this.semester.Text = "Current Semester";
            // 
            // courseSchedue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.semester);
            this.Controls.Add(this.selectedSemester);
            this.Controls.Add(this.dataGridView1);
            this.Name = "courseSchedue";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox selectedSemester;
        private System.Windows.Forms.TextBox semester;
    }
}