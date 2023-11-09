namespace ProjectManager.UI
{
    partial class AddProjectFileForm
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ProjectFileLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.NameTitleLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.CreateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProjectFileLogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(784, 125);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Project File";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProjectFileLogoPictureBox
            // 
            this.ProjectFileLogoPictureBox.Location = new System.Drawing.Point(5, 5);
            this.ProjectFileLogoPictureBox.Name = "ProjectFileLogoPictureBox";
            this.ProjectFileLogoPictureBox.Size = new System.Drawing.Size(120, 120);
            this.ProjectFileLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProjectFileLogoPictureBox.TabIndex = 3;
            this.ProjectFileLogoPictureBox.TabStop = false;
            // 
            // NameTitleLabel
            // 
            this.NameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTitleLabel.AutoSize = true;
            this.NameTitleLabel.Location = new System.Drawing.Point(203, 222);
            this.NameTitleLabel.Name = "NameTitleLabel";
            this.NameTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.NameTitleLabel.TabIndex = 8;
            this.NameTitleLabel.Text = "Name";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(200, 238);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(400, 29);
            this.NameTextBox.TabIndex = 7;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CreateButton.Location = new System.Drawing.Point(325, 385);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(150, 35);
            this.CreateButton.TabIndex = 10;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // AddProjectFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.NameTitleLabel);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ProjectFileLogoPictureBox);
            this.Controls.Add(this.TitleLabel);
            this.Name = "AddProjectFileForm";
            this.Text = "AddProjectFileForm";
            this.Load += new System.EventHandler(this.AddProjectFileForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProjectFileLogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.PictureBox ProjectFileLogoPictureBox;
        private System.Windows.Forms.Label NameTitleLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Button CreateButton;
    }
}