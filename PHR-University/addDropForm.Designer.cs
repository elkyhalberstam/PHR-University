namespace PHR_University
{
    partial class addDropForm
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
            this.submit = new System.Windows.Forms.Button();
            this.classSelect = new System.Windows.Forms.ComboBox();
            this.dropSelect = new System.Windows.Forms.RadioButton();
            this.semesterSelect = new System.Windows.Forms.ComboBox();
            this.addSelect = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(96, 309);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(90, 39);
            this.submit.TabIndex = 0;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // classSelect
            // 
            this.classSelect.FormattingEnabled = true;
            this.classSelect.Location = new System.Drawing.Point(278, 87);
            this.classSelect.Name = "classSelect";
            this.classSelect.Size = new System.Drawing.Size(254, 28);
            this.classSelect.TabIndex = 1;
            this.classSelect.SelectedIndexChanged += new System.EventHandler(this.classSelectChange);
            // 
            // dropSelect
            // 
            this.dropSelect.AutoSize = true;
            this.dropSelect.Location = new System.Drawing.Point(96, 181);
            this.dropSelect.Name = "dropSelect";
            this.dropSelect.Size = new System.Drawing.Size(112, 24);
            this.dropSelect.TabIndex = 3;
            this.dropSelect.TabStop = true;
            this.dropSelect.Text = "Drop Class";
            this.dropSelect.UseVisualStyleBackColor = true;
            this.dropSelect.CheckedChanged += new System.EventHandler(this.dropSelectChange);
            // 
            // semesterSelect
            // 
            this.semesterSelect.FormattingEnabled = true;
            this.semesterSelect.Location = new System.Drawing.Point(565, 87);
            this.semesterSelect.Name = "semesterSelect";
            this.semesterSelect.Size = new System.Drawing.Size(199, 28);
            this.semesterSelect.TabIndex = 4;
            this.semesterSelect.SelectedIndexChanged += new System.EventHandler(this.semesterSelectChange);
            // 
            // addSelect
            // 
            this.addSelect.AutoSize = true;
            this.addSelect.Location = new System.Drawing.Point(96, 139);
            this.addSelect.Name = "addSelect";
            this.addSelect.Size = new System.Drawing.Size(106, 24);
            this.addSelect.TabIndex = 2;
            this.addSelect.TabStop = true;
            this.addSelect.Text = "Add Class\r\n";
            this.addSelect.UseVisualStyleBackColor = true;
            this.addSelect.CheckedChanged += new System.EventHandler(this.addSelectChange);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(486, 271);
            this.dataGridView1.TabIndex = 5;
            // 
            // addDropForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.semesterSelect);
            this.Controls.Add(this.dropSelect);
            this.Controls.Add(this.addSelect);
            this.Controls.Add(this.classSelect);
            this.Controls.Add(this.submit);
            this.Name = "addDropForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.ComboBox classSelect;
        private System.Windows.Forms.RadioButton dropSelect;
        private System.Windows.Forms.ComboBox semesterSelect;
        private System.Windows.Forms.RadioButton addSelect;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}