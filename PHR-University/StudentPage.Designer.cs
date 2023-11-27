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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academicScheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lookUpClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDropClassesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrationHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentGradesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transcriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.requestOfficialTranscriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graduationStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helloToolStripMenuItem,
            this.registrationToolStripMenuItem,
            this.academicToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helloToolStripMenuItem
            // 
            this.helloToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.academicScheduleToolStripMenuItem});
            this.helloToolStripMenuItem.Name = "helloToolStripMenuItem";
            this.helloToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.helloToolStripMenuItem.Text = "Home";
            this.helloToolStripMenuItem.Click += new System.EventHandler(this.helloToolStripMenuItem_Click);
            // 
            // registrationToolStripMenuItem
            // 
            this.registrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lookUpClassesToolStripMenuItem,
            this.addDropClassesToolStripMenuItem,
            this.registrationStatusToolStripMenuItem});
            this.registrationToolStripMenuItem.Name = "registrationToolStripMenuItem";
            this.registrationToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.registrationToolStripMenuItem.Text = "Registration";
            // 
            // academicToolStripMenuItem
            // 
            this.academicToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currentGradesToolStripMenuItem,
            this.transcriptToolStripMenuItem,
            this.graduationStatusToolStripMenuItem});
            this.academicToolStripMenuItem.Name = "academicToolStripMenuItem";
            this.academicToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.academicToolStripMenuItem.Text = "Academic ";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.emailToolStripMenuItem.Text = "Email";
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.scheduleToolStripMenuItem.Text = "Student Schedule ";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // academicScheduleToolStripMenuItem
            // 
            this.academicScheduleToolStripMenuItem.Name = "academicScheduleToolStripMenuItem";
            this.academicScheduleToolStripMenuItem.Size = new System.Drawing.Size(226, 26);
            this.academicScheduleToolStripMenuItem.Text = "Academic Schedule ";
            // 
            // lookUpClassesToolStripMenuItem
            // 
            this.lookUpClassesToolStripMenuItem.Name = "lookUpClassesToolStripMenuItem";
            this.lookUpClassesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.lookUpClassesToolStripMenuItem.Text = "Look up classes";
            // 
            // addDropClassesToolStripMenuItem
            // 
            this.addDropClassesToolStripMenuItem.Name = "addDropClassesToolStripMenuItem";
            this.addDropClassesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addDropClassesToolStripMenuItem.Text = "Add/Drop classes";
            // 
            // registrationStatusToolStripMenuItem
            // 
            this.registrationStatusToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrationHistoryToolStripMenuItem});
            this.registrationStatusToolStripMenuItem.Name = "registrationStatusToolStripMenuItem";
            this.registrationStatusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registrationStatusToolStripMenuItem.Text = "Registration Status ";
            // 
            // registrationHistoryToolStripMenuItem
            // 
            this.registrationHistoryToolStripMenuItem.Name = "registrationHistoryToolStripMenuItem";
            this.registrationHistoryToolStripMenuItem.Size = new System.Drawing.Size(227, 26);
            this.registrationHistoryToolStripMenuItem.Text = "Registration History ";
            // 
            // currentGradesToolStripMenuItem
            // 
            this.currentGradesToolStripMenuItem.Name = "currentGradesToolStripMenuItem";
            this.currentGradesToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.currentGradesToolStripMenuItem.Text = "Current Grades ";
            // 
            // transcriptToolStripMenuItem
            // 
            this.transcriptToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.requestOfficialTranscriptToolStripMenuItem});
            this.transcriptToolStripMenuItem.Name = "transcriptToolStripMenuItem";
            this.transcriptToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transcriptToolStripMenuItem.Text = "Transcript";
            // 
            // requestOfficialTranscriptToolStripMenuItem
            // 
            this.requestOfficialTranscriptToolStripMenuItem.Name = "requestOfficialTranscriptToolStripMenuItem";
            this.requestOfficialTranscriptToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.requestOfficialTranscriptToolStripMenuItem.Text = "Request Official Transcript";
            // 
            // graduationStatusToolStripMenuItem
            // 
            this.graduationStatusToolStripMenuItem.Name = "graduationStatusToolStripMenuItem";
            this.graduationStatusToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.graduationStatusToolStripMenuItem.Text = "Graduation Status";
            // 
            // StudentPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentPage";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem academicScheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lookUpClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDropClassesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrationHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentGradesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transcriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem requestOfficialTranscriptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graduationStatusToolStripMenuItem;
    }
}