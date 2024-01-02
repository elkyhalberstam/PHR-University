namespace PHR_University
{
    partial class PCurrScheduleForm
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
            this.IDTextLabel = new System.Windows.Forms.Label();
            this.SemesterComboBox = new System.Windows.Forms.ComboBox();
            this.ScheduleGridView = new System.Windows.Forms.DataGridView();
            this.TitleLabelViewCurrentSched = new System.Windows.Forms.Label();
            this.ProfessorIDLabel = new System.Windows.Forms.Label();
            this.SelectSemesterLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // IDTextLabel
            // 
            this.IDTextLabel.AutoSize = true;
            this.IDTextLabel.Location = new System.Drawing.Point(432, 88);
            this.IDTextLabel.Name = "IDTextLabel";
            this.IDTextLabel.Size = new System.Drawing.Size(20, 16);
            this.IDTextLabel.TabIndex = 3;
            this.IDTextLabel.Text = "ID";
            // 
            // SemesterComboBox
            // 
            this.SemesterComboBox.FormattingEnabled = true;
            this.SemesterComboBox.Location = new System.Drawing.Point(435, 143);
            this.SemesterComboBox.Name = "SemesterComboBox";
            this.SemesterComboBox.Size = new System.Drawing.Size(138, 24);
            this.SemesterComboBox.TabIndex = 4;
            this.SemesterComboBox.Text = "Select Semester";
            this.SemesterComboBox.SelectedIndexChanged += new System.EventHandler(this.SemesterComboBox_SelectedIndexChanged);
            // 
            // ScheduleGridView
            // 
            this.ScheduleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ScheduleGridView.Location = new System.Drawing.Point(30, 201);
            this.ScheduleGridView.Name = "ScheduleGridView";
            this.ScheduleGridView.RowHeadersWidth = 51;
            this.ScheduleGridView.RowTemplate.Height = 24;
            this.ScheduleGridView.Size = new System.Drawing.Size(725, 225);
            this.ScheduleGridView.TabIndex = 6;
            // 
            // TitleLabelViewCurrentSched
            // 
            this.TitleLabelViewCurrentSched.AutoSize = true;
            this.TitleLabelViewCurrentSched.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TitleLabelViewCurrentSched.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TitleLabelViewCurrentSched.Location = new System.Drawing.Point(322, 31);
            this.TitleLabelViewCurrentSched.Name = "TitleLabelViewCurrentSched";
            this.TitleLabelViewCurrentSched.Size = new System.Drawing.Size(175, 18);
            this.TitleLabelViewCurrentSched.TabIndex = 7;
            this.TitleLabelViewCurrentSched.Text = "Professor Current Schedule ";
            this.TitleLabelViewCurrentSched.UseMnemonic = false;
            // 
            // ProfessorIDLabel
            // 
            this.ProfessorIDLabel.AutoSize = true;
            this.ProfessorIDLabel.Location = new System.Drawing.Point(283, 87);
            this.ProfessorIDLabel.Name = "ProfessorIDLabel";
            this.ProfessorIDLabel.Size = new System.Drawing.Size(87, 16);
            this.ProfessorIDLabel.TabIndex = 8;
            this.ProfessorIDLabel.Text = "Professor ID: ";
            // 
            // SelectSemesterLabel
            // 
            this.SelectSemesterLabel.AutoSize = true;
            this.SelectSemesterLabel.Location = new System.Drawing.Point(255, 146);
            this.SelectSemesterLabel.Name = "SelectSemesterLabel";
            this.SelectSemesterLabel.Size = new System.Drawing.Size(151, 16);
            this.SelectSemesterLabel.TabIndex = 9;
            this.SelectSemesterLabel.Text = "Select Current Semester";
            // 
            // PCurrScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectSemesterLabel);
            this.Controls.Add(this.ProfessorIDLabel);
            this.Controls.Add(this.TitleLabelViewCurrentSched);
            this.Controls.Add(this.ScheduleGridView);
            this.Controls.Add(this.SemesterComboBox);
            this.Controls.Add(this.IDTextLabel);
            this.Name = "PCurrScheduleForm";
            this.Text = "PCurrScheduleForm";
            ((System.ComponentModel.ISupportInitialize)(this.ScheduleGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label IDTextLabel;
        private System.Windows.Forms.ComboBox SemesterComboBox;
        private System.Windows.Forms.DataGridView ScheduleGridView;
        private System.Windows.Forms.Label TitleLabelViewCurrentSched;
        private System.Windows.Forms.Label ProfessorIDLabel;
        private System.Windows.Forms.Label SelectSemesterLabel;
    }
}