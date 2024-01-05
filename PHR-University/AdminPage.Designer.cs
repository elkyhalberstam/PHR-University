namespace PHR_University
{
    partial class ARegistration
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
            this.ALabelPanel = new System.Windows.Forms.Panel();
            this.ARegistrationButton = new System.Windows.Forms.Button();
            this.AHomeButton = new System.Windows.Forms.Button();
            this.ARegistartionPanel = new System.Windows.Forms.Panel();
            this.dropButton = new System.Windows.Forms.Button();
            this.AdminHomePanel = new System.Windows.Forms.Panel();
            this.AAcademicButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AEmailButton = new System.Windows.Forms.Button();
            this.ARegistrationAddDropButton = new System.Windows.Forms.Button();
            this.homeLabel = new System.Windows.Forms.Label();
            this.ARegistartionAssignClassesButton = new System.Windows.Forms.Button();
            this.ACourseSchedule = new System.Windows.Forms.Button();
            this.ALabelPanel.SuspendLayout();
            this.ARegistartionPanel.SuspendLayout();
            this.AdminHomePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ALabelPanel
            // 
            this.ALabelPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ALabelPanel.Controls.Add(this.ARegistrationButton);
            this.ALabelPanel.Controls.Add(this.AHomeButton);
            this.ALabelPanel.Location = new System.Drawing.Point(1, 11);
            this.ALabelPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ALabelPanel.Name = "ALabelPanel";
            this.ALabelPanel.Size = new System.Drawing.Size(800, 29);
            this.ALabelPanel.TabIndex = 9;
            // 
            // ARegistrationButton
            // 
            this.ARegistrationButton.Location = new System.Drawing.Point(343, 2);
            this.ARegistrationButton.Margin = new System.Windows.Forms.Padding(2);
            this.ARegistrationButton.Name = "ARegistrationButton";
            this.ARegistrationButton.Size = new System.Drawing.Size(115, 25);
            this.ARegistrationButton.TabIndex = 5;
            this.ARegistrationButton.Text = "Registration";
            this.ARegistrationButton.UseVisualStyleBackColor = true;
            this.ARegistrationButton.Click += new System.EventHandler(this.AMenuRegistration_Click);
            // 
            // AHomeButton
            // 
            this.AHomeButton.Location = new System.Drawing.Point(39, 3);
            this.AHomeButton.Margin = new System.Windows.Forms.Padding(2);
            this.AHomeButton.Name = "AHomeButton";
            this.AHomeButton.Size = new System.Drawing.Size(115, 25);
            this.AHomeButton.TabIndex = 4;
            this.AHomeButton.Text = "Home";
            this.AHomeButton.UseVisualStyleBackColor = true;
            this.AHomeButton.Click += new System.EventHandler(this.AMenuHome_Click);
            // 
            // ARegistartionPanel
            // 
            this.ARegistartionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.ARegistartionPanel.Controls.Add(this.AdminHomePanel);
            this.ARegistartionPanel.Controls.Add(this.ARegistrationAddDropButton);
            this.ARegistartionPanel.Controls.Add(this.homeLabel);
            this.ARegistartionPanel.Controls.Add(this.ARegistartionAssignClassesButton);
            this.ARegistartionPanel.Controls.Add(this.ACourseSchedule);
            this.ARegistartionPanel.Controls.Add(this.dropButton);
            this.ARegistartionPanel.Location = new System.Drawing.Point(1, 85);
            this.ARegistartionPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ARegistartionPanel.Name = "ARegistartionPanel";
            this.ARegistartionPanel.Size = new System.Drawing.Size(800, 276);
            this.ARegistartionPanel.TabIndex = 10;
            this.ARegistartionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ARegistartionPannel_Paint);
            // 
            // dropButton
            // 
            this.dropButton.Location = new System.Drawing.Point(444, 158);
            this.dropButton.Margin = new System.Windows.Forms.Padding(2);
            this.dropButton.Name = "dropButton";
            this.dropButton.Size = new System.Drawing.Size(115, 55);
            this.dropButton.TabIndex = 12;
            this.dropButton.Text = "Drop Class";
            this.dropButton.UseVisualStyleBackColor = true;
            this.dropButton.Click += new System.EventHandler(this.dropButton_Click);
            // 
            // AdminHomePanel
            // 
            this.AdminHomePanel.BackColor = System.Drawing.SystemColors.Control;
            this.AdminHomePanel.Controls.Add(this.AAcademicButton);
            this.AdminHomePanel.Controls.Add(this.label1);
            this.AdminHomePanel.Controls.Add(this.AEmailButton);
            this.AdminHomePanel.Location = new System.Drawing.Point(2, 2);
            this.AdminHomePanel.Margin = new System.Windows.Forms.Padding(2);
            this.AdminHomePanel.Name = "AdminHomePanel";
            this.AdminHomePanel.Size = new System.Drawing.Size(800, 276);
            this.AdminHomePanel.TabIndex = 11;
            this.AdminHomePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.AdminHomePanel_Paint);
            // 
            // AAcademicButton
            // 
            this.AAcademicButton.Location = new System.Drawing.Point(452, 156);
            this.AAcademicButton.Margin = new System.Windows.Forms.Padding(2);
            this.AAcademicButton.Name = "AAcademicButton";
            this.AAcademicButton.Size = new System.Drawing.Size(115, 55);
            this.AAcademicButton.TabIndex = 4;
            this.AAcademicButton.Text = "Academic";
            this.AAcademicButton.UseVisualStyleBackColor = true;
            this.AAcademicButton.Click += new System.EventHandler(this.AAcademicButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 46);
            this.label1.TabIndex = 3;
            this.label1.Text = "ADMIN HOME";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AEmailButton
            // 
            this.AEmailButton.Location = new System.Drawing.Point(227, 156);
            this.AEmailButton.Margin = new System.Windows.Forms.Padding(2);
            this.AEmailButton.Name = "AEmailButton";
            this.AEmailButton.Size = new System.Drawing.Size(115, 55);
            this.AEmailButton.TabIndex = 0;
            this.AEmailButton.Text = "Email";
            this.AEmailButton.UseVisualStyleBackColor = true;
            this.AEmailButton.Click += new System.EventHandler(this.AEmailButton_Click_1);
            // 
            // ARegistrationAddDropButton
            // 
            this.ARegistrationAddDropButton.Location = new System.Drawing.Point(288, 158);
            this.ARegistrationAddDropButton.Margin = new System.Windows.Forms.Padding(2);
            this.ARegistrationAddDropButton.Name = "ARegistrationAddDropButton";
            this.ARegistrationAddDropButton.Size = new System.Drawing.Size(115, 55);
            this.ARegistrationAddDropButton.TabIndex = 4;
            this.ARegistrationAddDropButton.Text = "Add Class";
            this.ARegistrationAddDropButton.UseVisualStyleBackColor = true;
            this.ARegistrationAddDropButton.Click += new System.EventHandler(this.AdminAddDropButton_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(170, 89);
            this.homeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(457, 46);
            this.homeLabel.TabIndex = 3;
            this.homeLabel.Text = "ADMIN REGISTRATION";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // ARegistartionAssignClassesButton
            // 
            this.ARegistartionAssignClassesButton.Location = new System.Drawing.Point(587, 158);
            this.ARegistartionAssignClassesButton.Margin = new System.Windows.Forms.Padding(2);
            this.ARegistartionAssignClassesButton.Name = "ARegistartionAssignClassesButton";
            this.ARegistartionAssignClassesButton.Size = new System.Drawing.Size(115, 55);
            this.ARegistartionAssignClassesButton.TabIndex = 2;
            this.ARegistartionAssignClassesButton.Text = "Assign Class";
            this.ARegistartionAssignClassesButton.UseVisualStyleBackColor = true;
            this.ARegistartionAssignClassesButton.Click += new System.EventHandler(this.ARegistartionAssignClassesButton_Click);
            // 
            // ACourseSchedule
            // 
            this.ACourseSchedule.Location = new System.Drawing.Point(143, 158);
            this.ACourseSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.ACourseSchedule.Name = "ACourseSchedule";
            this.ACourseSchedule.Size = new System.Drawing.Size(115, 55);
            this.ACourseSchedule.TabIndex = 0;
            this.ACourseSchedule.Text = "Semester Schedule";
            this.ACourseSchedule.UseVisualStyleBackColor = true;
            this.ACourseSchedule.Click += new System.EventHandler(this.ACourseSchedule_Click);
            // 
            // ARegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ARegistartionPanel);
            this.Controls.Add(this.ALabelPanel);
            this.Name = "ARegistration";
            this.Text = "ARegistration";
            this.Load += new System.EventHandler(this.ARegistration_Load);
            this.ALabelPanel.ResumeLayout(false);
            this.ARegistartionPanel.ResumeLayout(false);
            this.ARegistartionPanel.PerformLayout();
            this.AdminHomePanel.ResumeLayout(false);
            this.AdminHomePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ALabelPanel;
        private System.Windows.Forms.Button ARegistrationButton;
        private System.Windows.Forms.Button AHomeButton;
        private System.Windows.Forms.Panel ARegistartionPanel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Button ARegistartionAssignClassesButton;
        private System.Windows.Forms.Button ACourseSchedule;
        private System.Windows.Forms.Panel AdminHomePanel;
        private System.Windows.Forms.Button AAcademicButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AEmailButton;
        private System.Windows.Forms.Button dropButton;
        private System.Windows.Forms.Button ARegistrationAddDropButton;
    }
}