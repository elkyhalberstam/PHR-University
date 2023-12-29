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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menueAcademics = new System.Windows.Forms.Button();
            this.menuRegistratiom = new System.Windows.Forms.Button();
            this.HomeMenu = new System.Windows.Forms.Button();
            this.regisratinPanel = new System.Windows.Forms.Panel();
            this.registrationLabel = new System.Windows.Forms.Label();
            this.addDropButton = new System.Windows.Forms.Button();
            this.lookUPclasses = new System.Windows.Forms.Button();
            this.academicPanel = new System.Windows.Forms.Panel();
            this.transcriptButton = new System.Windows.Forms.Button();
            this.academicsLabel = new System.Windows.Forms.Label();
            this.gradStatusButton = new System.Windows.Forms.Button();
            this.currentGradesButton = new System.Windows.Forms.Button();
            this.HomePannel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.asButton = new System.Windows.Forms.Button();
            this.courseButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.regisratinPanel.SuspendLayout();
            this.academicPanel.SuspendLayout();
            this.HomePannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.menueAcademics);
            this.panel1.Controls.Add(this.menuRegistratiom);
            this.panel1.Controls.Add(this.HomeMenu);
            this.panel1.Location = new System.Drawing.Point(0, 10);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 36);
            this.panel1.TabIndex = 2;
            // 
            // menueAcademics
            // 
            this.menueAcademics.Location = new System.Drawing.Point(878, 2);
            this.menueAcademics.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menueAcademics.Name = "menueAcademics";
            this.menueAcademics.Size = new System.Drawing.Size(154, 31);
            this.menueAcademics.TabIndex = 6;
            this.menueAcademics.Text = "Academics";
            this.menueAcademics.UseVisualStyleBackColor = true;
            this.menueAcademics.Click += new System.EventHandler(this.menueAcademics_Click);
            // 
            // menuRegistratiom
            // 
            this.menuRegistratiom.Location = new System.Drawing.Point(457, 2);
            this.menuRegistratiom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuRegistratiom.Name = "menuRegistratiom";
            this.menuRegistratiom.Size = new System.Drawing.Size(154, 31);
            this.menuRegistratiom.TabIndex = 5;
            this.menuRegistratiom.Text = "Registration";
            this.menuRegistratiom.UseVisualStyleBackColor = true;
            this.menuRegistratiom.Click += new System.EventHandler(this.menuRegistratiom_Click);
            // 
            // HomeMenu
            // 
            this.HomeMenu.Location = new System.Drawing.Point(105, 3);
            this.HomeMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomeMenu.Name = "HomeMenu";
            this.HomeMenu.Size = new System.Drawing.Size(154, 31);
            this.HomeMenu.TabIndex = 7;
            this.HomeMenu.Text = "Home";
            this.HomeMenu.UseVisualStyleBackColor = true;
            this.HomeMenu.Click += new System.EventHandler(this.HomeMenu_Click);
            // 
            // regisratinPanel
            // 
            this.regisratinPanel.BackColor = System.Drawing.SystemColors.Control;
            this.regisratinPanel.Controls.Add(this.registrationLabel);
            this.regisratinPanel.Controls.Add(this.addDropButton);
            this.regisratinPanel.Controls.Add(this.lookUPclasses);
            this.regisratinPanel.Location = new System.Drawing.Point(3, 107);
            this.regisratinPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regisratinPanel.Name = "regisratinPanel";
            this.regisratinPanel.Size = new System.Drawing.Size(1067, 339);
            this.regisratinPanel.TabIndex = 4;
            // 
            // registrationLabel
            // 
            this.registrationLabel.AutoSize = true;
            this.registrationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrationLabel.Location = new System.Drawing.Point(385, 103);
            this.registrationLabel.Name = "registrationLabel";
            this.registrationLabel.Size = new System.Drawing.Size(280, 58);
            this.registrationLabel.TabIndex = 3;
            this.registrationLabel.Text = "REGISTER";
            this.registrationLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // addDropButton
            // 
            this.addDropButton.Location = new System.Drawing.Point(650, 192);
            this.addDropButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addDropButton.Name = "addDropButton";
            this.addDropButton.Size = new System.Drawing.Size(154, 68);
            this.addDropButton.TabIndex = 2;
            this.addDropButton.Text = "Add / Drop Classes";
            this.addDropButton.UseVisualStyleBackColor = true;
            this.addDropButton.Click += new System.EventHandler(this.addDropButton_Click);
            // 
            // lookUPclasses
            // 
            this.lookUPclasses.Location = new System.Drawing.Point(265, 192);
            this.lookUPclasses.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookUPclasses.Name = "lookUPclasses";
            this.lookUPclasses.Size = new System.Drawing.Size(154, 68);
            this.lookUPclasses.TabIndex = 1;
            this.lookUPclasses.Text = "Look up Classes";
            this.lookUPclasses.UseVisualStyleBackColor = true;
            this.lookUPclasses.Click += new System.EventHandler(this.lookUPclasses_Click);
            // 
            // academicPanel
            // 
            this.academicPanel.BackColor = System.Drawing.SystemColors.Control;
            this.academicPanel.Controls.Add(this.transcriptButton);
            this.academicPanel.Controls.Add(this.academicsLabel);
            this.academicPanel.Controls.Add(this.gradStatusButton);
            this.academicPanel.Controls.Add(this.currentGradesButton);
            this.academicPanel.Location = new System.Drawing.Point(3, 106);
            this.academicPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.academicPanel.Name = "academicPanel";
            this.academicPanel.Size = new System.Drawing.Size(1067, 339);
            this.academicPanel.TabIndex = 5;
            // 
            // transcriptButton
            // 
            this.transcriptButton.Location = new System.Drawing.Point(457, 192);
            this.transcriptButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transcriptButton.Name = "transcriptButton";
            this.transcriptButton.Size = new System.Drawing.Size(154, 68);
            this.transcriptButton.TabIndex = 4;
            this.transcriptButton.Text = " Transcript";
            this.transcriptButton.UseVisualStyleBackColor = true;
            this.transcriptButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // academicsLabel
            // 
            this.academicsLabel.AutoSize = true;
            this.academicsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.academicsLabel.Location = new System.Drawing.Point(385, 103);
            this.academicsLabel.Name = "academicsLabel";
            this.academicsLabel.Size = new System.Drawing.Size(321, 58);
            this.academicsLabel.TabIndex = 3;
            this.academicsLabel.Text = "ACADEMICS";
            // 
            // gradStatusButton
            // 
            this.gradStatusButton.Location = new System.Drawing.Point(769, 192);
            this.gradStatusButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gradStatusButton.Name = "gradStatusButton";
            this.gradStatusButton.Size = new System.Drawing.Size(154, 68);
            this.gradStatusButton.TabIndex = 2;
            this.gradStatusButton.Text = "Graduation Status";
            this.gradStatusButton.UseVisualStyleBackColor = true;
            this.gradStatusButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // currentGradesButton
            // 
            this.currentGradesButton.Location = new System.Drawing.Point(152, 192);
            this.currentGradesButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currentGradesButton.Name = "currentGradesButton";
            this.currentGradesButton.Size = new System.Drawing.Size(154, 68);
            this.currentGradesButton.TabIndex = 1;
            this.currentGradesButton.Text = "Current Grades";
            this.currentGradesButton.UseVisualStyleBackColor = true;
            this.currentGradesButton.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // HomePannel
            // 
            this.HomePannel.BackColor = System.Drawing.SystemColors.Control;
            this.HomePannel.Controls.Add(this.homeLabel);
            this.HomePannel.Controls.Add(this.asButton);
            this.HomePannel.Controls.Add(this.courseButton);
            this.HomePannel.Controls.Add(this.emailButton);
            this.HomePannel.Location = new System.Drawing.Point(3, 107);
            this.HomePannel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.HomePannel.Name = "HomePannel";
            this.HomePannel.Size = new System.Drawing.Size(1067, 339);
            this.HomePannel.TabIndex = 5;
            this.HomePannel.Paint += new System.Windows.Forms.PaintEventHandler(this.HomePannel_Paint);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(347, 106);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(424, 58);
            this.homeLabel.TabIndex = 3;
            this.homeLabel.Text = "STUDENT HOME";
            // 
            // asButton
            // 
            this.asButton.Location = new System.Drawing.Point(758, 194);
            this.asButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.asButton.Name = "asButton";
            this.asButton.Size = new System.Drawing.Size(154, 68);
            this.asButton.TabIndex = 2;
            this.asButton.Text = "Academic Schedule";
            this.asButton.UseVisualStyleBackColor = true;
            // 
            // courseButton
            // 
            this.courseButton.Location = new System.Drawing.Point(444, 194);
            this.courseButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.courseButton.Name = "courseButton";
            this.courseButton.Size = new System.Drawing.Size(154, 68);
            this.courseButton.TabIndex = 1;
            this.courseButton.Text = "Course Schedule";
            this.courseButton.UseVisualStyleBackColor = true;
            this.courseButton.Click += new System.EventHandler(this.courseButton_Click_1);
            // 
            // emailButton
            // 
            this.emailButton.Location = new System.Drawing.Point(152, 194);
            this.emailButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailButton.Name = "emailButton";
            this.emailButton.Size = new System.Drawing.Size(154, 68);
            this.emailButton.TabIndex = 0;
            this.emailButton.Text = "Email";
            this.emailButton.UseVisualStyleBackColor = true;
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.HomePannel);
            this.Controls.Add(this.academicPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.regisratinPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentPage";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentPage_FormClosing);
            this.Load += new System.EventHandler(this.StudentPage_Load);
            this.panel1.ResumeLayout(false);
            this.regisratinPanel.ResumeLayout(false);
            this.regisratinPanel.PerformLayout();
            this.academicPanel.ResumeLayout(false);
            this.academicPanel.PerformLayout();
            this.HomePannel.ResumeLayout(false);
            this.HomePannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menueAcademics;
        private System.Windows.Forms.Button menuRegistratiom;
        private System.Windows.Forms.Panel regisratinPanel;
        private System.Windows.Forms.Label registrationLabel;
        private System.Windows.Forms.Button addDropButton;
        private System.Windows.Forms.Button lookUPclasses;
        private System.Windows.Forms.Panel academicPanel;
        private System.Windows.Forms.Button transcriptButton;
        private System.Windows.Forms.Label academicsLabel;
        private System.Windows.Forms.Button gradStatusButton;
        private System.Windows.Forms.Button currentGradesButton;
        private System.Windows.Forms.Panel HomePannel;
        private System.Windows.Forms.Button asButton;
        private System.Windows.Forms.Button courseButton;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Button HomeMenu;
        private System.Windows.Forms.Label homeLabel;
    }
}