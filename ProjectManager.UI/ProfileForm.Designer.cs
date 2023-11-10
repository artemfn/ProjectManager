namespace ProjectManager.UI
{
    partial class ProfileForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.DescriptionLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.UserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.AgeNumeric = new System.Windows.Forms.NumericUpDown();
            this.UserTypeTitleLabel = new System.Windows.Forms.Label();
            this.GenderTitleLabel = new System.Windows.Forms.Label();
            this.EmailTitleLabel = new System.Windows.Forms.Label();
            this.AgeTitleLabel = new System.Windows.Forms.Label();
            this.PasswordTitleLabel = new System.Windows.Forms.Label();
            this.NameTitleLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SaveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(278, 364);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(150, 35);
            this.SaveButton.TabIndex = 26;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // DescriptionLinkedLabel
            // 
            this.DescriptionLinkedLabel.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.DescriptionLinkedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescriptionLinkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLinkedLabel.LinkColor = System.Drawing.Color.Black;
            this.DescriptionLinkedLabel.Location = new System.Drawing.Point(275, 302);
            this.DescriptionLinkedLabel.Name = "DescriptionLinkedLabel";
            this.DescriptionLinkedLabel.Size = new System.Drawing.Size(150, 35);
            this.DescriptionLinkedLabel.TabIndex = 25;
            this.DescriptionLinkedLabel.TabStop = true;
            this.DescriptionLinkedLabel.Text = "Description";
            this.DescriptionLinkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DescriptionLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DescriptionLinkedLabel_LinkClicked);
            // 
            // UserTypeComboBox
            // 
            this.UserTypeComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserTypeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserTypeComboBox.FormattingEnabled = true;
            this.UserTypeComboBox.Items.AddRange(new object[] {
            "Ordinary",
            "Student",
            "Teacher",
            "Company",
            "Other"});
            this.UserTypeComboBox.Location = new System.Drawing.Point(353, 270);
            this.UserTypeComboBox.Name = "UserTypeComboBox";
            this.UserTypeComboBox.Size = new System.Drawing.Size(197, 28);
            this.UserTypeComboBox.TabIndex = 24;
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenderComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Man",
            "Woman",
            "Other"});
            this.GenderComboBox.Location = new System.Drawing.Point(353, 218);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(197, 28);
            this.GenderComboBox.TabIndex = 23;
            // 
            // AgeNumeric
            // 
            this.AgeNumeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeNumeric.Location = new System.Drawing.Point(353, 167);
            this.AgeNumeric.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.AgeNumeric.Name = "AgeNumeric";
            this.AgeNumeric.Size = new System.Drawing.Size(197, 29);
            this.AgeNumeric.TabIndex = 22;
            this.AgeNumeric.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // UserTypeTitleLabel
            // 
            this.UserTypeTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserTypeTitleLabel.AutoSize = true;
            this.UserTypeTitleLabel.Location = new System.Drawing.Point(356, 254);
            this.UserTypeTitleLabel.Name = "UserTypeTitleLabel";
            this.UserTypeTitleLabel.Size = new System.Drawing.Size(52, 13);
            this.UserTypeTitleLabel.TabIndex = 20;
            this.UserTypeTitleLabel.Text = "User type";
            // 
            // GenderTitleLabel
            // 
            this.GenderTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenderTitleLabel.AutoSize = true;
            this.GenderTitleLabel.Location = new System.Drawing.Point(356, 202);
            this.GenderTitleLabel.Name = "GenderTitleLabel";
            this.GenderTitleLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderTitleLabel.TabIndex = 18;
            this.GenderTitleLabel.Text = "Gender";
            // 
            // EmailTitleLabel
            // 
            this.EmailTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailTitleLabel.AutoSize = true;
            this.EmailTitleLabel.Location = new System.Drawing.Point(153, 254);
            this.EmailTitleLabel.Name = "EmailTitleLabel";
            this.EmailTitleLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailTitleLabel.TabIndex = 21;
            this.EmailTitleLabel.Text = "Email";
            // 
            // AgeTitleLabel
            // 
            this.AgeTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgeTitleLabel.AutoSize = true;
            this.AgeTitleLabel.Location = new System.Drawing.Point(356, 151);
            this.AgeTitleLabel.Name = "AgeTitleLabel";
            this.AgeTitleLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeTitleLabel.TabIndex = 16;
            this.AgeTitleLabel.Text = "Age";
            // 
            // PasswordTitleLabel
            // 
            this.PasswordTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordTitleLabel.AutoSize = true;
            this.PasswordTitleLabel.Location = new System.Drawing.Point(153, 202);
            this.PasswordTitleLabel.Name = "PasswordTitleLabel";
            this.PasswordTitleLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordTitleLabel.TabIndex = 19;
            this.PasswordTitleLabel.Text = "Password";
            // 
            // NameTitleLabel
            // 
            this.NameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTitleLabel.AutoSize = true;
            this.NameTitleLabel.Location = new System.Drawing.Point(153, 152);
            this.NameTitleLabel.Name = "NameTitleLabel";
            this.NameTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.NameTitleLabel.TabIndex = 17;
            this.NameTitleLabel.Text = "Name";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(150, 270);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(197, 29);
            this.EmailTextBox.TabIndex = 15;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(150, 218);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(197, 29);
            this.PasswordTextBox.TabIndex = 14;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(150, 168);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(197, 29);
            this.NameTextBox.TabIndex = 13;
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(684, 120);
            this.TitleLabel.TabIndex = 27;
            this.TitleLabel.Text = "Profile";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.DescriptionLinkedLabel);
            this.Controls.Add(this.UserTypeComboBox);
            this.Controls.Add(this.GenderComboBox);
            this.Controls.Add(this.AgeNumeric);
            this.Controls.Add(this.UserTypeTitleLabel);
            this.Controls.Add(this.GenderTitleLabel);
            this.Controls.Add(this.EmailTitleLabel);
            this.Controls.Add(this.AgeTitleLabel);
            this.Controls.Add(this.PasswordTitleLabel);
            this.Controls.Add(this.NameTitleLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ProfileForm";
            this.Text = "Profile";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.LinkLabel DescriptionLinkedLabel;
        private System.Windows.Forms.ComboBox UserTypeComboBox;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.NumericUpDown AgeNumeric;
        private System.Windows.Forms.Label UserTypeTitleLabel;
        private System.Windows.Forms.Label GenderTitleLabel;
        private System.Windows.Forms.Label EmailTitleLabel;
        private System.Windows.Forms.Label AgeTitleLabel;
        private System.Windows.Forms.Label PasswordTitleLabel;
        private System.Windows.Forms.Label NameTitleLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label TitleLabel;
    }
}