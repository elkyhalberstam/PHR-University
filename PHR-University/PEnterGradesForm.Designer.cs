namespace PHR_University
{
    partial class PEnterGradesForm
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
            this.EnterGradesTitleLabel = new System.Windows.Forms.Label();
            this.SelectClassLabel = new System.Windows.Forms.Label();
            this.SelectStudentLabel = new System.Windows.Forms.Label();
            this.EnterGradeLabel = new System.Windows.Forms.Label();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.SelectStudentComboBox = new System.Windows.Forms.ComboBox();
            this.SelectClassComboBox = new System.Windows.Forms.ComboBox();
            this.GradesComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // EnterGradesTitleLabel
            // 
            this.EnterGradesTitleLabel.AutoSize = true;
            this.EnterGradesTitleLabel.Location = new System.Drawing.Point(305, 40);
            this.EnterGradesTitleLabel.Name = "EnterGradesTitleLabel";
            this.EnterGradesTitleLabel.Size = new System.Drawing.Size(181, 16);
            this.EnterGradesTitleLabel.TabIndex = 0;
            this.EnterGradesTitleLabel.Text = "Professor Enter Grades Form";
            // 
            // SelectClassLabel
            // 
            this.SelectClassLabel.AutoSize = true;
            this.SelectClassLabel.Location = new System.Drawing.Point(83, 91);
            this.SelectClassLabel.Name = "SelectClassLabel";
            this.SelectClassLabel.Size = new System.Drawing.Size(85, 16);
            this.SelectClassLabel.TabIndex = 1;
            this.SelectClassLabel.Text = "Select Class ";
            // 
            // SelectStudentLabel
            // 
            this.SelectStudentLabel.AutoSize = true;
            this.SelectStudentLabel.Location = new System.Drawing.Point(372, 91);
            this.SelectStudentLabel.Name = "SelectStudentLabel";
            this.SelectStudentLabel.Size = new System.Drawing.Size(93, 16);
            this.SelectStudentLabel.TabIndex = 3;
            this.SelectStudentLabel.Text = "Select Student";
            // 
            // EnterGradeLabel
            // 
            this.EnterGradeLabel.AutoSize = true;
            this.EnterGradeLabel.Location = new System.Drawing.Point(600, 91);
            this.EnterGradeLabel.Name = "EnterGradeLabel";
            this.EnterGradeLabel.Size = new System.Drawing.Size(89, 16);
            this.EnterGradeLabel.TabIndex = 5;
            this.EnterGradeLabel.Text = "Select Grade:";
            // 
            // SubmitButton
            // 
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.Location = new System.Drawing.Point(346, 341);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(124, 49);
            this.SubmitButton.TabIndex = 8;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // SelectStudentComboBox
            // 
            this.SelectStudentComboBox.FormattingEnabled = true;
            this.SelectStudentComboBox.Location = new System.Drawing.Point(346, 126);
            this.SelectStudentComboBox.Name = "SelectStudentComboBox";
            this.SelectStudentComboBox.Size = new System.Drawing.Size(121, 24);
            this.SelectStudentComboBox.TabIndex = 12;
            this.SelectStudentComboBox.Text = "Select Student ";
            this.SelectStudentComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectStudentComboBox_SelectedIndexChanged);
            // 
            // SelectClassComboBox
            // 
            this.SelectClassComboBox.FormattingEnabled = true;
            this.SelectClassComboBox.Location = new System.Drawing.Point(47, 125);
            this.SelectClassComboBox.Name = "SelectClassComboBox";
            this.SelectClassComboBox.Size = new System.Drawing.Size(191, 24);
            this.SelectClassComboBox.TabIndex = 13;
            this.SelectClassComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectClassComboBox_SelectedIndexChanged);
            // 
            // GradesComboBox
            // 
            this.GradesComboBox.FormattingEnabled = true;
            this.GradesComboBox.Items.AddRange(new object[] {
            "A+",
            "A",
            "A-",
            "B+",
            "B",
            "B-",
            "C+",
            "C",
            "C-",
            "D+",
            "D",
            "D-",
            "F"});
            this.GradesComboBox.Location = new System.Drawing.Point(594, 125);
            this.GradesComboBox.Name = "GradesComboBox";
            this.GradesComboBox.Size = new System.Drawing.Size(121, 24);
            this.GradesComboBox.TabIndex = 14;
            this.GradesComboBox.SelectedIndexChanged += new System.EventHandler(this.GradesComboBox_SelectedIndexChanged);
            // 
            // PEnterGradesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GradesComboBox);
            this.Controls.Add(this.SelectClassComboBox);
            this.Controls.Add(this.SelectStudentComboBox);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.EnterGradeLabel);
            this.Controls.Add(this.SelectStudentLabel);
            this.Controls.Add(this.SelectClassLabel);
            this.Controls.Add(this.EnterGradesTitleLabel);
            this.Name = "PEnterGradesForm";
            this.Text = "PEnterGradesForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EnterGradesTitleLabel;
        private System.Windows.Forms.Label SelectClassLabel;
        private System.Windows.Forms.Label SelectStudentLabel;
        private System.Windows.Forms.Label EnterGradeLabel;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.ComboBox SelectStudentComboBox;
        private System.Windows.Forms.ComboBox SelectClassComboBox;
        private System.Windows.Forms.ComboBox GradesComboBox;
    }
}