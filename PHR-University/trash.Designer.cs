namespace PHR_University
{
    partial class AdminPage
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
            this.AHomePannel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.AAcademicScheduleButton = new System.Windows.Forms.Button();
            this.AemailButton = new System.Windows.Forms.Button();
            this.ALbaelPanel = new System.Windows.Forms.Panel();
            this.AmenuRegistratiom = new System.Windows.Forms.Button();
            this.AmenuHome = new System.Windows.Forms.Button();
            this.AHomePannel.SuspendLayout();
            this.ALbaelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // AHomePannel
            // 
            this.AHomePannel.BackColor = System.Drawing.SystemColors.Control;
            this.AHomePannel.Controls.Add(this.homeLabel);
            this.AHomePannel.Controls.Add(this.AAcademicScheduleButton);
            this.AHomePannel.Controls.Add(this.AemailButton);
            this.AHomePannel.Location = new System.Drawing.Point(0, 90);
            this.AHomePannel.Margin = new System.Windows.Forms.Padding(2);
            this.AHomePannel.Name = "AHomePannel";
            this.AHomePannel.Size = new System.Drawing.Size(800, 276);
            this.AHomePannel.TabIndex = 7;
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(260, 86);
            this.homeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(279, 46);
            this.homeLabel.TabIndex = 3;
            this.homeLabel.Text = "ADMIN HOME";
            this.homeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.homeLabel.Click += new System.EventHandler(this.homeLabel_Click);
            // 
            // AAcademicScheduleButton
            // 
            this.AAcademicScheduleButton.Location = new System.Drawing.Point(433, 158);
            this.AAcademicScheduleButton.Margin = new System.Windows.Forms.Padding(2);
            this.AAcademicScheduleButton.Name = "AAcademicScheduleButton";
            this.AAcademicScheduleButton.Size = new System.Drawing.Size(115, 55);
            this.AAcademicScheduleButton.TabIndex = 2;
            this.AAcademicScheduleButton.Text = "Academic Schedule";
            this.AAcademicScheduleButton.UseVisualStyleBackColor = true;
            this.AAcademicScheduleButton.Click += new System.EventHandler(this.AAcademicScheduleButton_Click);
            // 
            // AemailButton
            // 
            this.AemailButton.Location = new System.Drawing.Point(245, 158);
            this.AemailButton.Margin = new System.Windows.Forms.Padding(2);
            this.AemailButton.Name = "AemailButton";
            this.AemailButton.Size = new System.Drawing.Size(115, 55);
            this.AemailButton.TabIndex = 0;
            this.AemailButton.Text = "Email";
            this.AemailButton.UseVisualStyleBackColor = true;
            this.AemailButton.Click += new System.EventHandler(this.AemailButton_Click);
            // 
            // ALbaelPanel
            // 
            this.ALbaelPanel.Controls.Add(this.AmenuRegistratiom);
            this.ALbaelPanel.Controls.Add(this.AmenuHome);
            this.ALbaelPanel.Location = new System.Drawing.Point(0, 1);
            this.ALbaelPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ALbaelPanel.Name = "ALbaelPanel";
            this.ALbaelPanel.Size = new System.Drawing.Size(800, 29);
            this.ALbaelPanel.TabIndex = 8;
            // 
            // AmenuRegistratiom
            // 
            this.AmenuRegistratiom.Location = new System.Drawing.Point(343, 2);
            this.AmenuRegistratiom.Margin = new System.Windows.Forms.Padding(2);
            this.AmenuRegistratiom.Name = "AmenuRegistratiom";
            this.AmenuRegistratiom.Size = new System.Drawing.Size(115, 25);
            this.AmenuRegistratiom.TabIndex = 5;
            this.AmenuRegistratiom.Text = "Registration";
            this.AmenuRegistratiom.UseVisualStyleBackColor = true;
            this.AmenuRegistratiom.Click += new System.EventHandler(this.menuRegistratiom_Click);
            // 
            // AmenuHome
            // 
            this.AmenuHome.Location = new System.Drawing.Point(39, 3);
            this.AmenuHome.Margin = new System.Windows.Forms.Padding(2);
            this.AmenuHome.Name = "AmenuHome";
            this.AmenuHome.Size = new System.Drawing.Size(115, 25);
            this.AmenuHome.TabIndex = 4;
            this.AmenuHome.Text = "Home";
            this.AmenuHome.UseVisualStyleBackColor = true;
            this.AmenuHome.Click += new System.EventHandler(this.AmenuHome_Click);
            // 
            // AdminPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ALbaelPanel);
            this.Controls.Add(this.AHomePannel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AdminPage";
            this.Text = "AdminPage";
            this.AHomePannel.ResumeLayout(false);
            this.AHomePannel.PerformLayout();
            this.ALbaelPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AHomePannel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Button AAcademicScheduleButton;
        private System.Windows.Forms.Button AemailButton;
        private System.Windows.Forms.Panel ALbaelPanel;
        private System.Windows.Forms.Button AmenuRegistratiom;
        private System.Windows.Forms.Button AmenuHome;
    }
}