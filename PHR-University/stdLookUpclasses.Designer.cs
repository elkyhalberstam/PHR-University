namespace PHR_University
{
    partial class stdLookUpclasses
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
            this.selectSemester = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.semesterText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // selectSemester
            // 
            this.selectSemester.FormattingEnabled = true;
            this.selectSemester.Location = new System.Drawing.Point(416, 52);
            this.selectSemester.Name = "selectSemester";
            this.selectSemester.Size = new System.Drawing.Size(207, 28);
            this.selectSemester.TabIndex = 0;
            this.selectSemester.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(798, 337);
            this.dataGridView1.TabIndex = 2;
            // 
            // semesterText
            // 
            this.semesterText.Location = new System.Drawing.Point(180, 52);
            this.semesterText.Name = "semesterText";
            this.semesterText.ReadOnly = true;
            this.semesterText.Size = new System.Drawing.Size(148, 26);
            this.semesterText.TabIndex = 3;
            this.semesterText.Text = "Semester";
            // 
            // lookUpclasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.semesterText);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.selectSemester);
            this.Name = "lookUpclasses";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selectSemester;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox semesterText;
    }
}