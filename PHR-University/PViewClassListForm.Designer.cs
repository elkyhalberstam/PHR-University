namespace PHR_University
{
    partial class PViewClassListForm
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
            this.ViewClassListTitleLabel = new System.Windows.Forms.Label();
            this.SelectClassLabel = new System.Windows.Forms.Label();
            this.SelectClassComboBox = new System.Windows.Forms.ComboBox();
            this.ClassListGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ClassListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ViewClassListTitleLabel
            // 
            this.ViewClassListTitleLabel.AutoSize = true;
            this.ViewClassListTitleLabel.Location = new System.Drawing.Point(324, 40);
            this.ViewClassListTitleLabel.Name = "ViewClassListTitleLabel";
            this.ViewClassListTitleLabel.Size = new System.Drawing.Size(194, 16);
            this.ViewClassListTitleLabel.TabIndex = 0;
            this.ViewClassListTitleLabel.Text = "Professor View Class List Form ";
            // 
            // SelectClassLabel
            // 
            this.SelectClassLabel.AutoSize = true;
            this.SelectClassLabel.Location = new System.Drawing.Point(66, 81);
            this.SelectClassLabel.Name = "SelectClassLabel";
            this.SelectClassLabel.Size = new System.Drawing.Size(85, 16);
            this.SelectClassLabel.TabIndex = 1;
            this.SelectClassLabel.Text = "Select Class ";
            // 
            // SelectClassComboBox
            // 
            this.SelectClassComboBox.FormattingEnabled = true;
            this.SelectClassComboBox.Location = new System.Drawing.Point(27, 124);
            this.SelectClassComboBox.Name = "SelectClassComboBox";
            this.SelectClassComboBox.Size = new System.Drawing.Size(231, 24);
            this.SelectClassComboBox.TabIndex = 2;
            this.SelectClassComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectClassComboBox_SelectedIndexChanged);
            // 
            // ClassListGridView
            // 
            this.ClassListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassListGridView.Location = new System.Drawing.Point(291, 107);
            this.ClassListGridView.Name = "ClassListGridView";
            this.ClassListGridView.RowHeadersWidth = 51;
            this.ClassListGridView.RowTemplate.Height = 24;
            this.ClassListGridView.Size = new System.Drawing.Size(485, 302);
            this.ClassListGridView.TabIndex = 3;
            // 
            // PViewClassListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClassListGridView);
            this.Controls.Add(this.SelectClassComboBox);
            this.Controls.Add(this.SelectClassLabel);
            this.Controls.Add(this.ViewClassListTitleLabel);
            this.Name = "PViewClassListForm";
            this.Text = "PViewClassListForm";
            ((System.ComponentModel.ISupportInitialize)(this.ClassListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ViewClassListTitleLabel;
        private System.Windows.Forms.Label SelectClassLabel;
        private System.Windows.Forms.ComboBox SelectClassComboBox;
        private System.Windows.Forms.DataGridView ClassListGridView;
    }
}