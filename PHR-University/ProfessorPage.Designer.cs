namespace PHR_University
{
    partial class ProfessorPage
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
            this.HomePanel = new System.Windows.Forms.Panel();
            this.HomeTextLabel = new System.Windows.Forms.Label();
            this.AcademicSchedButton = new System.Windows.Forms.Button();
            this.CourseButton = new System.Windows.Forms.Button();
            this.EmailButton = new System.Windows.Forms.Button();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.MenuAcademicsButton = new System.Windows.Forms.Button();
            this.MenuRegistrationButton = new System.Windows.Forms.Button();
            this.MenuHomeButton = new System.Windows.Forms.Button();
            this.HomePanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePanel
            // 
            this.HomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.HomePanel.Controls.Add(this.HomeTextLabel);
            this.HomePanel.Controls.Add(this.AcademicSchedButton);
            this.HomePanel.Controls.Add(this.CourseButton);
            this.HomePanel.Controls.Add(this.EmailButton);
            this.HomePanel.Location = new System.Drawing.Point(0, 120);
            this.HomePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePanel.Name = "HomePanel";
            this.HomePanel.Size = new System.Drawing.Size(1067, 339);
            this.HomePanel.TabIndex = 6;
            // 
            // HomeTextLabel
            // 
            this.HomeTextLabel.AutoSize = true;
            this.HomeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTextLabel.Location = new System.Drawing.Point(433, 106);
            this.HomeTextLabel.Name = "HomeTextLabel";
            this.HomeTextLabel.Size = new System.Drawing.Size(175, 58);
            this.HomeTextLabel.TabIndex = 3;
            this.HomeTextLabel.Text = "HOME";
            this.HomeTextLabel.Click += new System.EventHandler(this.HomeTextLabel_Click);
            // 
            // AcademicSchedButton
            // 
            this.AcademicSchedButton.Location = new System.Drawing.Point(758, 194);
            this.AcademicSchedButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AcademicSchedButton.Name = "AcademicSchedButton";
            this.AcademicSchedButton.Size = new System.Drawing.Size(154, 68);
            this.AcademicSchedButton.TabIndex = 2;
            this.AcademicSchedButton.Text = "Academic Schedule";
            this.AcademicSchedButton.UseVisualStyleBackColor = true;
            this.AcademicSchedButton.Click += new System.EventHandler(this.AcademicSchedButton_Click);
            // 
            // CourseButton
            // 
            this.CourseButton.Location = new System.Drawing.Point(444, 194);
            this.CourseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CourseButton.Name = "CourseButton";
            this.CourseButton.Size = new System.Drawing.Size(154, 68);
            this.CourseButton.TabIndex = 1;
            this.CourseButton.Text = "Course Schedule";
            this.CourseButton.UseVisualStyleBackColor = true;
            this.CourseButton.Click += new System.EventHandler(this.CourseButton_Click);
            // 
            // EmailButton
            // 
            this.EmailButton.Location = new System.Drawing.Point(152, 194);
            this.EmailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailButton.Name = "EmailButton";
            this.EmailButton.Size = new System.Drawing.Size(154, 68);
            this.EmailButton.TabIndex = 0;
            this.EmailButton.Text = "Email";
            this.EmailButton.UseVisualStyleBackColor = true;
            this.EmailButton.Click += new System.EventHandler(this.EmailButton_Click);
            // 
            // menuPanel
            // 
            this.MenuPanel.Controls.Add(this.MenuAcademicsButton);
            this.MenuPanel.Controls.Add(this.MenuRegistrationButton);
            this.MenuPanel.Controls.Add(this.MenuHomeButton);
            this.MenuPanel.Location = new System.Drawing.Point(-1, 1);
            this.MenuPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuPanel.Name = "menuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(1067, 36);
            this.MenuPanel.TabIndex = 4;
            // 
            // MenuAcademicsButton
            // 
            this.MenuAcademicsButton.Location = new System.Drawing.Point(878, 2);
            this.MenuAcademicsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuAcademicsButton.Name = "MenuAcademicsButton";
            this.MenuAcademicsButton.Size = new System.Drawing.Size(154, 31);
            this.MenuAcademicsButton.TabIndex = 6;
            this.MenuAcademicsButton.Text = "Academics";
            this.MenuAcademicsButton.UseVisualStyleBackColor = true;
            this.MenuAcademicsButton.Click += new System.EventHandler(this.MenuAcademicsButton_Click);
            // 
            // MenuRegistrationButton
            // 
            this.MenuRegistrationButton.Location = new System.Drawing.Point(457, 2);
            this.MenuRegistrationButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuRegistrationButton.Name = "MenuRegistrationButton";
            this.MenuRegistrationButton.Size = new System.Drawing.Size(154, 31);
            this.MenuRegistrationButton.TabIndex = 5;
            this.MenuRegistrationButton.Text = "Registration";
            this.MenuRegistrationButton.UseVisualStyleBackColor = true;
            this.MenuRegistrationButton.Click += new System.EventHandler(this.MenuRegistrationButton_Click);
            // 
            // MenuHomeButton
            // 
            this.MenuHomeButton.Location = new System.Drawing.Point(52, 4);
            this.MenuHomeButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MenuHomeButton.Name = "MenuHomeButton";
            this.MenuHomeButton.Size = new System.Drawing.Size(154, 31);
            this.MenuHomeButton.TabIndex = 4;
            this.MenuHomeButton.Text = "Home";
            this.MenuHomeButton.UseVisualStyleBackColor = true;
            this.MenuHomeButton.Click += new System.EventHandler(this.MenuHomeButton_Click);
            // 
            // ProfessorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.MenuPanel);
            this.Controls.Add(this.HomePanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfessorPage";
            this.Text = "ProfessorPage";
            this.HomePanel.ResumeLayout(false);
            this.HomePanel.PerformLayout();
            this.MenuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HomePanel;
        private System.Windows.Forms.Label HomeTextLabel;
        private System.Windows.Forms.Button AcademicSchedButton;
        private System.Windows.Forms.Button CourseButton;
        private System.Windows.Forms.Button EmailButton;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Button MenuAcademicsButton;
        private System.Windows.Forms.Button MenuRegistrationButton;
        private System.Windows.Forms.Button MenuHomeButton;
    }
}