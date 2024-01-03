namespace PHR_University
{
    partial class StudentPage
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
            this.studentMenuPanel = new System.Windows.Forms.Panel();
            this.StudentAcademicsMenu = new System.Windows.Forms.Button();
            this.StudentRegistrationMenu = new System.Windows.Forms.Button();
            this.StudentHomeMenu = new System.Windows.Forms.Button();
            this.studentRegisratinPanel = new System.Windows.Forms.Panel();
            this.studentRagisterLabel = new System.Windows.Forms.Label();
            this.studentAddDropButton = new System.Windows.Forms.Button();
            this.studentLookUPclassesbutton = new System.Windows.Forms.Button();
            this.studentAcademicPanel = new System.Windows.Forms.Panel();
            this.majorMinorStatusButton = new System.Windows.Forms.Button();
            this.studentAcademicsLabel = new System.Windows.Forms.Label();
            this.graduationStatusButton = new System.Windows.Forms.Button();
            this.transcriptButton = new System.Windows.Forms.Button();
            this.studnetHomePannel = new System.Windows.Forms.Panel();
            this.studentHomeLabel = new System.Windows.Forms.Label();
            this.StudentAcademicScheduleButton = new System.Windows.Forms.Button();
            this.StudentCourseScheduleButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.studentMenuPanel.SuspendLayout();
            this.studentRegisratinPanel.SuspendLayout();
            this.studentAcademicPanel.SuspendLayout();
            this.studnetHomePannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentMenuPanel
            // 
            this.studentMenuPanel.Controls.Add(this.StudentAcademicsMenu);
            this.studentMenuPanel.Controls.Add(this.StudentRegistrationMenu);
            this.studentMenuPanel.Controls.Add(this.StudentHomeMenu);
            this.studentMenuPanel.Location = new System.Drawing.Point(0, 12);
            this.studentMenuPanel.Name = "studentMenuPanel";
            this.studentMenuPanel.Size = new System.Drawing.Size(1200, 45);
            this.studentMenuPanel.TabIndex = 2;
            // 
            // StudentAcademicsMenu
            // 
            this.StudentAcademicsMenu.Location = new System.Drawing.Point(988, 3);
            this.StudentAcademicsMenu.Name = "StudentAcademicsMenu";
            this.StudentAcademicsMenu.Size = new System.Drawing.Size(173, 39);
            this.StudentAcademicsMenu.TabIndex = 6;
            this.StudentAcademicsMenu.Text = "Academics";
            this.StudentAcademicsMenu.UseVisualStyleBackColor = true;
            this.StudentAcademicsMenu.Click += new System.EventHandler(this.stdAcademicsMenu_click);
            // 
            // StudentRegistrationMenu
            // 
            this.StudentRegistrationMenu.Location = new System.Drawing.Point(514, 3);
            this.StudentRegistrationMenu.Name = "StudentRegistrationMenu";
            this.StudentRegistrationMenu.Size = new System.Drawing.Size(173, 39);
            this.StudentRegistrationMenu.TabIndex = 5;
            this.StudentRegistrationMenu.Text = "Registration";
            this.StudentRegistrationMenu.UseVisualStyleBackColor = true;
            this.StudentRegistrationMenu.Click += new System.EventHandler(this.stdRegistrationMenue_click);
            // 
            // StudentHomeMenu
            // 
            this.StudentHomeMenu.Location = new System.Drawing.Point(118, 4);
            this.StudentHomeMenu.Name = "StudentHomeMenu";
            this.StudentHomeMenu.Size = new System.Drawing.Size(173, 39);
            this.StudentHomeMenu.TabIndex = 7;
            this.StudentHomeMenu.Text = "Home";
            this.StudentHomeMenu.UseVisualStyleBackColor = true;
            this.StudentHomeMenu.Click += new System.EventHandler(this.stdHomeMenu_Click);
            // 
            // studentRegisratinPanel
            // 
            this.studentRegisratinPanel.BackColor = System.Drawing.SystemColors.Control;
            this.studentRegisratinPanel.Controls.Add(this.studentRagisterLabel);
            this.studentRegisratinPanel.Controls.Add(this.studentAddDropButton);
            this.studentRegisratinPanel.Controls.Add(this.studentLookUPclassesbutton);
            this.studentRegisratinPanel.Location = new System.Drawing.Point(3, 134);
            this.studentRegisratinPanel.Name = "studentRegisratinPanel";
            this.studentRegisratinPanel.Size = new System.Drawing.Size(1200, 424);
            this.studentRegisratinPanel.TabIndex = 4;
            // 
            // studentRagisterLabel
            // 
            this.studentRagisterLabel.AutoSize = true;
            this.studentRagisterLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentRagisterLabel.Location = new System.Drawing.Point(292, 128);
            this.studentRagisterLabel.Name = "studentRagisterLabel";
            this.studentRagisterLabel.Size = new System.Drawing.Size(636, 69);
            this.studentRagisterLabel.TabIndex = 3;
            this.studentRagisterLabel.Text = "STUDENT REGISTER";
            // 
            // studentAddDropButton
            // 
            this.studentAddDropButton.Location = new System.Drawing.Point(731, 240);
            this.studentAddDropButton.Name = "studentAddDropButton";
            this.studentAddDropButton.Size = new System.Drawing.Size(173, 85);
            this.studentAddDropButton.TabIndex = 2;
            this.studentAddDropButton.Text = "Add / Drop Classes";
            this.studentAddDropButton.UseVisualStyleBackColor = true;
            this.studentAddDropButton.Click += new System.EventHandler(this.stdAddDropButton_Click);
            // 
            // studentLookUPclassesbutton
            // 
            this.studentLookUPclassesbutton.Location = new System.Drawing.Point(298, 240);
            this.studentLookUPclassesbutton.Name = "studentLookUPclassesbutton";
            this.studentLookUPclassesbutton.Size = new System.Drawing.Size(173, 85);
            this.studentLookUPclassesbutton.TabIndex = 1;
            this.studentLookUPclassesbutton.Text = "Look up Classes";
            this.studentLookUPclassesbutton.UseVisualStyleBackColor = true;
            this.studentLookUPclassesbutton.Click += new System.EventHandler(this.stdLookUPclasses_Click);
            // 
            // studentAcademicPanel
            // 
            this.studentAcademicPanel.BackColor = System.Drawing.SystemColors.Control;
            this.studentAcademicPanel.Controls.Add(this.majorMinorStatusButton);
            this.studentAcademicPanel.Controls.Add(this.studentAcademicsLabel);
            this.studentAcademicPanel.Controls.Add(this.graduationStatusButton);
            this.studentAcademicPanel.Controls.Add(this.transcriptButton);
            this.studentAcademicPanel.Location = new System.Drawing.Point(3, 134);
            this.studentAcademicPanel.Name = "studentAcademicPanel";
            this.studentAcademicPanel.Size = new System.Drawing.Size(1200, 424);
            this.studentAcademicPanel.TabIndex = 5;
            // 
            // majorMinorStatusButton
            // 
            this.majorMinorStatusButton.Location = new System.Drawing.Point(514, 240);
            this.majorMinorStatusButton.Name = "majorMinorStatusButton";
            this.majorMinorStatusButton.Size = new System.Drawing.Size(173, 85);
            this.majorMinorStatusButton.TabIndex = 4;
            this.majorMinorStatusButton.TabStop = false;
            this.majorMinorStatusButton.Text = "Major / Minor Status";
            this.majorMinorStatusButton.UseVisualStyleBackColor = true;
            this.majorMinorStatusButton.Click += new System.EventHandler(this.stdMinorMajor_click);
            // 
            // studentAcademicsLabel
            // 
            this.studentAcademicsLabel.AutoSize = true;
            this.studentAcademicsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentAcademicsLabel.Location = new System.Drawing.Point(273, 126);
            this.studentAcademicsLabel.Name = "studentAcademicsLabel";
            this.studentAcademicsLabel.Size = new System.Drawing.Size(685, 69);
            this.studentAcademicsLabel.TabIndex = 3;
            this.studentAcademicsLabel.Text = "STUDENT ACADEMICS";
            // 
            // graduationStatusButton
            // 
            this.graduationStatusButton.Location = new System.Drawing.Point(865, 240);
            this.graduationStatusButton.Name = "graduationStatusButton";
            this.graduationStatusButton.Size = new System.Drawing.Size(173, 85);
            this.graduationStatusButton.TabIndex = 2;
            this.graduationStatusButton.Text = "Graduation Status";
            this.graduationStatusButton.UseVisualStyleBackColor = true;
            this.graduationStatusButton.Click += new System.EventHandler(this.stdGraduationStatus_click);
            // 
            // transcriptButton
            // 
            this.transcriptButton.Location = new System.Drawing.Point(172, 240);
            this.transcriptButton.Name = "transcriptButton";
            this.transcriptButton.Size = new System.Drawing.Size(173, 85);
            this.transcriptButton.TabIndex = 1;
            this.transcriptButton.Text = "Transcript";
            this.transcriptButton.UseVisualStyleBackColor = true;
            this.transcriptButton.Click += new System.EventHandler(this.stdTranscript_Click);
            // 
            // studnetHomePannel
            // 
            this.studnetHomePannel.BackColor = System.Drawing.SystemColors.Control;
            this.studnetHomePannel.Controls.Add(this.studentHomeLabel);
            this.studnetHomePannel.Controls.Add(this.StudentAcademicScheduleButton);
            this.studnetHomePannel.Controls.Add(this.StudentCourseScheduleButton);
            this.studnetHomePannel.Controls.Add(this.emailButton);
            this.studnetHomePannel.Location = new System.Drawing.Point(2, 133);
            this.studnetHomePannel.Name = "studnetHomePannel";
            this.studnetHomePannel.Size = new System.Drawing.Size(1200, 424);
            this.studnetHomePannel.TabIndex = 5;
            // 
            // studentHomeLabel
            // 
            this.studentHomeLabel.AutoSize = true;
            this.studentHomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentHomeLabel.Location = new System.Drawing.Point(343, 129);
            this.studentHomeLabel.Name = "studentHomeLabel";
            this.studentHomeLabel.Size = new System.Drawing.Size(509, 69);
            this.studentHomeLabel.TabIndex = 3;
            this.studentHomeLabel.Text = "STUDENT HOME";
            // 
            // StudentAcademicScheduleButton
            // 
            this.StudentAcademicScheduleButton.Location = new System.Drawing.Point(853, 243);
            this.StudentAcademicScheduleButton.Name = "StudentAcademicScheduleButton";
            this.StudentAcademicScheduleButton.Size = new System.Drawing.Size(173, 85);
            this.StudentAcademicScheduleButton.TabIndex = 2;
            this.StudentAcademicScheduleButton.Text = "Academic Schedule";
            this.StudentAcademicScheduleButton.UseVisualStyleBackColor = true;
            // 
            // StudentCourseScheduleButton
            // 
            this.StudentCourseScheduleButton.Location = new System.Drawing.Point(499, 243);
            this.StudentCourseScheduleButton.Name = "StudentCourseScheduleButton";
            this.StudentCourseScheduleButton.Size = new System.Drawing.Size(173, 85);
            this.StudentCourseScheduleButton.TabIndex = 1;
            this.StudentCourseScheduleButton.Text = "Course Schedule";
            this.StudentCourseScheduleButton.UseVisualStyleBackColor = true;
            this.StudentCourseScheduleButton.Click += new System.EventHandler(this.stdCourseSchedlue_click);
            // 
            // emailButton
            // 
            this.emailButton.Location = new System.Drawing.Point(171, 243);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(173, 85);
            this.emailButton.TabIndex = 0;
            this.emailButton.Text = "Email";
            this.emailButton.UseVisualStyleBackColor = true;
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.studnetHomePannel);
            this.Controls.Add(this.studentAcademicPanel);
            this.Controls.Add(this.studentMenuPanel);
            this.Controls.Add(this.studentRegisratinPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "StudentPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentPage_FormClosing);
            this.studentMenuPanel.ResumeLayout(false);
            this.studentRegisratinPanel.ResumeLayout(false);
            this.studentRegisratinPanel.PerformLayout();
            this.studentAcademicPanel.ResumeLayout(false);
            this.studentAcademicPanel.PerformLayout();
            this.studnetHomePannel.ResumeLayout(false);
            this.studnetHomePannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel studentMenuPanel;
        private System.Windows.Forms.Button StudentAcademicsMenu;
        private System.Windows.Forms.Button StudentRegistrationMenu;
        private System.Windows.Forms.Panel studentRegisratinPanel;
        private System.Windows.Forms.Label studentRagisterLabel;
        private System.Windows.Forms.Button studentAddDropButton;
        private System.Windows.Forms.Button studentLookUPclassesbutton;
        private System.Windows.Forms.Panel studentAcademicPanel;
        private System.Windows.Forms.Button majorMinorStatusButton;
        private System.Windows.Forms.Label studentAcademicsLabel;
        private System.Windows.Forms.Button graduationStatusButton;
        private System.Windows.Forms.Button transcriptButton;
        private System.Windows.Forms.Panel studnetHomePannel;
        private System.Windows.Forms.Button StudentAcademicScheduleButton;
        private System.Windows.Forms.Button StudentCourseScheduleButton;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button StudentHomeMenu;
        private System.Windows.Forms.Label studentHomeLabel;
    }
}