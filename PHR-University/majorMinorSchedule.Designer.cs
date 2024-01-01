namespace PHR_University
{
    partial class majorMinorSchedule
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.majorCreditTarget = new System.Windows.Forms.TextBox();
            this.majorTotalCredits = new System.Windows.Forms.TextBox();
            this.minorCreditTarget = new System.Windows.Forms.TextBox();
            this.minorTotalCredits = new System.Windows.Forms.TextBox();
            this.major = new System.Windows.Forms.TextBox();
            this.minor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(496, 296);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(501, 155);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(299, 296);
            this.dataGridView2.TabIndex = 1;
            // 
            // majorCreditTarget
            // 
            this.majorCreditTarget.Location = new System.Drawing.Point(105, 62);
            this.majorCreditTarget.Name = "majorCreditTarget";
            this.majorCreditTarget.Size = new System.Drawing.Size(259, 26);
            this.majorCreditTarget.TabIndex = 2;
            // 
            // majorTotalCredits
            // 
            this.majorTotalCredits.Location = new System.Drawing.Point(104, 105);
            this.majorTotalCredits.Name = "majorTotalCredits";
            this.majorTotalCredits.Size = new System.Drawing.Size(259, 26);
            this.majorTotalCredits.TabIndex = 3;
            // 
            // minorCreditTarget
            // 
            this.minorCreditTarget.Location = new System.Drawing.Point(529, 59);
            this.minorCreditTarget.Name = "minorCreditTarget";
            this.minorCreditTarget.Size = new System.Drawing.Size(259, 26);
            this.minorCreditTarget.TabIndex = 4;
            // 
            // minorTotalCredits
            // 
            this.minorTotalCredits.Location = new System.Drawing.Point(529, 104);
            this.minorTotalCredits.Name = "minorTotalCredits";
            this.minorTotalCredits.Size = new System.Drawing.Size(259, 26);
            this.minorTotalCredits.TabIndex = 5;
            // 
            // major
            // 
            this.major.Location = new System.Drawing.Point(135, 15);
            this.major.Name = "major";
            this.major.Size = new System.Drawing.Size(199, 26);
            this.major.TabIndex = 6;
            // 
            // minor
            // 
            this.minor.Location = new System.Drawing.Point(561, 15);
            this.minor.Name = "minor";
            this.minor.Size = new System.Drawing.Size(199, 26);
            this.minor.TabIndex = 7;
            // 
            // majorMinorSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.minor);
            this.Controls.Add(this.major);
            this.Controls.Add(this.minorTotalCredits);
            this.Controls.Add(this.minorCreditTarget);
            this.Controls.Add(this.majorTotalCredits);
            this.Controls.Add(this.majorCreditTarget);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "majorMinorSchedule";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox majorCreditTarget;
        private System.Windows.Forms.TextBox majorTotalCredits;
        private System.Windows.Forms.TextBox minorCreditTarget;
        private System.Windows.Forms.TextBox minorTotalCredits;
        private System.Windows.Forms.TextBox major;
        private System.Windows.Forms.TextBox minor;
    }
}