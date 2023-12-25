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
            this.HomePannel = new System.Windows.Forms.Panel();
            this.homeLabel = new System.Windows.Forms.Label();
            this.asButton = new System.Windows.Forms.Button();
            this.courseButton = new System.Windows.Forms.Button();
            this.emailButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menueAcademics = new System.Windows.Forms.Button();
            this.menuRegistratiom = new System.Windows.Forms.Button();
            this.menuHome = new System.Windows.Forms.Button();
            this.HomePannel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomePannel
            // 
            this.HomePannel.BackColor = System.Drawing.SystemColors.Control;
            this.HomePannel.Controls.Add(this.homeLabel);
            this.HomePannel.Controls.Add(this.asButton);
            this.HomePannel.Controls.Add(this.courseButton);
            this.HomePannel.Controls.Add(this.emailButton);
            this.HomePannel.Location = new System.Drawing.Point(0, 150);
            this.HomePannel.Name = "HomePannel";
            this.HomePannel.Size = new System.Drawing.Size(1200, 424);
            this.HomePannel.TabIndex = 6;
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeLabel.Location = new System.Drawing.Point(487, 132);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(210, 69);
            this.homeLabel.TabIndex = 3;
            this.homeLabel.Text = "HOME";
            // 
            // asButton
            // 
            this.asButton.Location = new System.Drawing.Point(853, 243);
            this.asButton.Name = "asButton";
            this.asButton.Size = new System.Drawing.Size(173, 85);
            this.asButton.TabIndex = 2;
            this.asButton.Text = "Academic Schedule";
            this.asButton.UseVisualStyleBackColor = true;
            // 
            // courseButton
            // 
            this.courseButton.Location = new System.Drawing.Point(499, 243);
            this.courseButton.Name = "courseButton";
            this.courseButton.Size = new System.Drawing.Size(173, 85);
            this.courseButton.TabIndex = 1;
            this.courseButton.Text = "Course Schedule";
            this.courseButton.UseVisualStyleBackColor = true;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.menueAcademics);
            this.panel1.Controls.Add(this.menuRegistratiom);
            this.panel1.Controls.Add(this.menuHome);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 45);
            this.panel1.TabIndex = 4;
            // 
            // menueAcademics
            // 
            this.menueAcademics.Location = new System.Drawing.Point(988, 3);
            this.menueAcademics.Name = "menueAcademics";
            this.menueAcademics.Size = new System.Drawing.Size(173, 39);
            this.menueAcademics.TabIndex = 6;
            this.menueAcademics.Text = "Academics";
            this.menueAcademics.UseVisualStyleBackColor = true;
            // 
            // menuRegistratiom
            // 
            this.menuRegistratiom.Location = new System.Drawing.Point(514, 3);
            this.menuRegistratiom.Name = "menuRegistratiom";
            this.menuRegistratiom.Size = new System.Drawing.Size(173, 39);
            this.menuRegistratiom.TabIndex = 5;
            this.menuRegistratiom.Text = "Registration";
            this.menuRegistratiom.UseVisualStyleBackColor = true;
            // 
            // menuHome
            // 
            this.menuHome.Location = new System.Drawing.Point(59, 5);
            this.menuHome.Name = "menuHome";
            this.menuHome.Size = new System.Drawing.Size(173, 39);
            this.menuHome.TabIndex = 4;
            this.menuHome.Text = "Home";
            this.menuHome.UseVisualStyleBackColor = true;
            // 
            // ProfessorPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.HomePannel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ProfessorPage";
            this.Text = "ProfessorPage";
            this.HomePannel.ResumeLayout(false);
            this.HomePannel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel HomePannel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Button asButton;
        private System.Windows.Forms.Button courseButton;
        private System.Windows.Forms.Button emailButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button menueAcademics;
        private System.Windows.Forms.Button menuRegistratiom;
        private System.Windows.Forms.Button menuHome;
    }
}