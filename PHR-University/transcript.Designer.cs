namespace PHR_University
{
    partial class transcript
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
            this.creditTarget = new System.Windows.Forms.TextBox();
            this.totalCredits = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(800, 378);
            this.dataGridView1.TabIndex = 0;
            // 
            // creditTarget
            // 
            this.creditTarget.Location = new System.Drawing.Point(90, 33);
            this.creditTarget.Name = "creditTarget";
            this.creditTarget.Size = new System.Drawing.Size(280, 26);
            this.creditTarget.TabIndex = 1;
            this.creditTarget.Text = "Required Crudetis for Graduation: 120";
            // 
            // totalCredits
            // 
            this.totalCredits.Location = new System.Drawing.Point(390, 33);
            this.totalCredits.Name = "totalCredits";
            this.totalCredits.ReadOnly = true;
            this.totalCredits.Size = new System.Drawing.Size(334, 26);
            this.totalCredits.TabIndex = 2;
            // 
            // transcript
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.totalCredits);
            this.Controls.Add(this.creditTarget);
            this.Controls.Add(this.dataGridView1);
            this.Name = "transcript";
            this.Text = "transcript";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox creditTarget;
        private System.Windows.Forms.TextBox totalCredits;
    }
}