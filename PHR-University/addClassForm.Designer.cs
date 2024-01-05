namespace PHR_University
{
    partial class addClassForm
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
            this.addClassButton = new System.Windows.Forms.Button();
            this.className = new System.Windows.Forms.TextBox();
            this.CreditsApplied = new System.Windows.Forms.TextBox();
            this.departmentString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addClassButton
            // 
            this.addClassButton.Location = new System.Drawing.Point(124, 251);
            this.addClassButton.Name = "addClassButton";
            this.addClassButton.Size = new System.Drawing.Size(75, 23);
            this.addClassButton.TabIndex = 0;
            this.addClassButton.Text = "Add Class";
            this.addClassButton.UseVisualStyleBackColor = true;
            this.addClassButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // className
            // 
            this.className.Location = new System.Drawing.Point(111, 41);
            this.className.Name = "className";
            this.className.Size = new System.Drawing.Size(100, 20);
            this.className.TabIndex = 1;
            this.className.Text = "Name";
            this.className.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // CreditsApplied
            // 
            this.CreditsApplied.Location = new System.Drawing.Point(111, 161);
            this.CreditsApplied.Name = "CreditsApplied";
            this.CreditsApplied.Size = new System.Drawing.Size(100, 20);
            this.CreditsApplied.TabIndex = 2;
            this.CreditsApplied.Text = "Credits Applied";
            this.CreditsApplied.TextChanged += new System.EventHandler(this.CreditsApplied_TextChanged);
            // 
            // departmentString
            // 
            this.departmentString.Location = new System.Drawing.Point(111, 100);
            this.departmentString.Name = "departmentString";
            this.departmentString.Size = new System.Drawing.Size(100, 20);
            this.departmentString.TabIndex = 3;
            this.departmentString.Text = "Department";
            this.departmentString.TextChanged += new System.EventHandler(this.Department_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 4;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // addClassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departmentString);
            this.Controls.Add(this.CreditsApplied);
            this.Controls.Add(this.className);
            this.Controls.Add(this.addClassButton);
            this.Name = "addClassForm";
            this.Text = "addClassForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addClassButton;
        private System.Windows.Forms.TextBox className;
        private System.Windows.Forms.TextBox CreditsApplied;
        private System.Windows.Forms.TextBox departmentString;
        private System.Windows.Forms.Label label1;
    }
}