namespace PHR_University
{
    partial class stdMajorMinorSchedule
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
            this.majorCreditTarget = new System.Windows.Forms.TextBox();
            this.majorTotalCredits = new System.Windows.Forms.TextBox();
            this.minorCreditTarget = new System.Windows.Forms.TextBox();
            this.minorTotalCredits = new System.Windows.Forms.TextBox();
            this.major = new System.Windows.Forms.TextBox();
            this.minor = new System.Windows.Forms.TextBox();
            this.switchMajor = new System.Windows.Forms.Button();
            this.switchMinor = new System.Windows.Forms.Button();
            this.chooseMajor = new System.Windows.Forms.ComboBox();
            this.chooseMinor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // majorCreditTarget
            // 
            this.majorCreditTarget.Location = new System.Drawing.Point(55, 138);
            this.majorCreditTarget.Name = "majorCreditTarget";
            this.majorCreditTarget.Size = new System.Drawing.Size(259, 26);
            this.majorCreditTarget.TabIndex = 2;
            // 
            // majorTotalCredits
            // 
            this.majorTotalCredits.Location = new System.Drawing.Point(54, 181);
            this.majorTotalCredits.Name = "majorTotalCredits";
            this.majorTotalCredits.Size = new System.Drawing.Size(259, 26);
            this.majorTotalCredits.TabIndex = 3;
            // 
            // minorCreditTarget
            // 
            this.minorCreditTarget.Location = new System.Drawing.Point(474, 135);
            this.minorCreditTarget.Name = "minorCreditTarget";
            this.minorCreditTarget.Size = new System.Drawing.Size(259, 26);
            this.minorCreditTarget.TabIndex = 4;
            // 
            // minorTotalCredits
            // 
            this.minorTotalCredits.Location = new System.Drawing.Point(474, 180);
            this.minorTotalCredits.Name = "minorTotalCredits";
            this.minorTotalCredits.Size = new System.Drawing.Size(259, 26);
            this.minorTotalCredits.TabIndex = 5;
            // 
            // major
            // 
            this.major.Location = new System.Drawing.Point(85, 91);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(199, 26);
            this.major.TabIndex = 6;
            // 
            // minor
            // 
            this.minor.Location = new System.Drawing.Point(506, 91);
            this.minor.Name = "minor";
            this.minor.Size = new System.Drawing.Size(199, 26);
            this.minor.TabIndex = 7;
            // 
            // switchMajor
            // 
            this.switchMajor.Location = new System.Drawing.Point(97, 328);
            this.switchMajor.Name = "switchMajor";
            this.switchMajor.Size = new System.Drawing.Size(158, 42);
            this.switchMajor.TabIndex = 8;
            this.switchMajor.Text = "Switch Major";
            this.switchMajor.UseVisualStyleBackColor = true;
            this.switchMajor.Click += new System.EventHandler(this.switchMajor_Click);
            // 
            // switchMinor
            // 
            this.switchMinor.Location = new System.Drawing.Point(527, 328);
            this.switchMinor.Name = "switchMinor";
            this.switchMinor.Size = new System.Drawing.Size(158, 42);
            this.switchMinor.TabIndex = 9;
            this.switchMinor.Text = "Switch Minor";
            this.switchMinor.UseVisualStyleBackColor = true;
            this.switchMinor.Click += new System.EventHandler(this.switchMinor_Click);
            // 
            // chooseMajor
            // 
            this.chooseMajor.FormattingEnabled = true;
            this.chooseMajor.Location = new System.Drawing.Point(68, 294);
            this.chooseMajor.Name = "chooseMajor";
            this.chooseMajor.Size = new System.Drawing.Size(216, 28);
            this.chooseMajor.TabIndex = 10;
            this.chooseMajor.SelectedIndexChanged += new System.EventHandler(this.chooseMajor_SelectedIndexChanged);
            // 
            // chooseMinor
            // 
            this.chooseMinor.FormattingEnabled = true;
            this.chooseMinor.Location = new System.Drawing.Point(492, 294);
            this.chooseMinor.Name = "chooseMinor";
            this.chooseMinor.Size = new System.Drawing.Size(216, 28);
            this.chooseMinor.TabIndex = 11;
            this.chooseMinor.SelectedIndexChanged += new System.EventHandler(this.chooseMinor_SelectedIndexChanged);
            // 
            // majorMinorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chooseMinor);
            this.Controls.Add(this.chooseMajor);
            this.Controls.Add(this.switchMinor);
            this.Controls.Add(this.switchMajor);
            this.Controls.Add(this.minor);
            this.Controls.Add(this.major);
            this.Controls.Add(this.minorTotalCredits);
            this.Controls.Add(this.minorCreditTarget);
            this.Controls.Add(this.majorTotalCredits);
            this.Controls.Add(this.majorCreditTarget);
            this.Name = "majorMinorSchedule";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox majorCreditTarget;
        private System.Windows.Forms.TextBox majorTotalCredits;
        private System.Windows.Forms.TextBox minorCreditTarget;
        private System.Windows.Forms.TextBox minorTotalCredits;
        private System.Windows.Forms.TextBox major;
        private System.Windows.Forms.TextBox minor;
        private System.Windows.Forms.Button switchMajor;
        private System.Windows.Forms.Button switchMinor;
        private System.Windows.Forms.ComboBox chooseMajor;
        private System.Windows.Forms.ComboBox chooseMinor;
    }
}