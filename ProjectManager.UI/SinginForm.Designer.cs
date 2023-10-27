namespace ProjectManager.UI
{
    partial class SinginForm
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.NameTitleLabel = new System.Windows.Forms.Label();
            this.PasswordTitleLabel = new System.Windows.Forms.Label();
            this.EmailTitleLabel = new System.Windows.Forms.Label();
            this.AgeTitleLabel = new System.Windows.Forms.Label();
            this.GenderTitleLabel = new System.Windows.Forms.Label();
            this.UserTypeTitleLabel = new System.Windows.Forms.Label();
            this.AgeNumeric = new System.Windows.Forms.NumericUpDown();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.UserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.DescriptionLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.SinginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(784, 120);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Project Manager";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(200, 168);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(197, 29);
            this.NameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(200, 219);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(197, 29);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailTextBox.Location = new System.Drawing.Point(200, 271);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(197, 29);
            this.EmailTextBox.TabIndex = 4;
            // 
            // NameTitleLabel
            // 
            this.NameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTitleLabel.AutoSize = true;
            this.NameTitleLabel.Location = new System.Drawing.Point(202, 152);
            this.NameTitleLabel.Name = "NameTitleLabel";
            this.NameTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.NameTitleLabel.TabIndex = 5;
            this.NameTitleLabel.Text = "Name";
            // 
            // PasswordTitleLabel
            // 
            this.PasswordTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordTitleLabel.AutoSize = true;
            this.PasswordTitleLabel.Location = new System.Drawing.Point(202, 203);
            this.PasswordTitleLabel.Name = "PasswordTitleLabel";
            this.PasswordTitleLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordTitleLabel.TabIndex = 6;
            this.PasswordTitleLabel.Text = "Password";
            // 
            // EmailTitleLabel
            // 
            this.EmailTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.EmailTitleLabel.AutoSize = true;
            this.EmailTitleLabel.Location = new System.Drawing.Point(202, 255);
            this.EmailTitleLabel.Name = "EmailTitleLabel";
            this.EmailTitleLabel.Size = new System.Drawing.Size(32, 13);
            this.EmailTitleLabel.TabIndex = 7;
            this.EmailTitleLabel.Text = "Email";
            // 
            // AgeTitleLabel
            // 
            this.AgeTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgeTitleLabel.AutoSize = true;
            this.AgeTitleLabel.Location = new System.Drawing.Point(405, 152);
            this.AgeTitleLabel.Name = "AgeTitleLabel";
            this.AgeTitleLabel.Size = new System.Drawing.Size(26, 13);
            this.AgeTitleLabel.TabIndex = 5;
            this.AgeTitleLabel.Text = "Age";
            // 
            // GenderTitleLabel
            // 
            this.GenderTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GenderTitleLabel.AutoSize = true;
            this.GenderTitleLabel.Location = new System.Drawing.Point(405, 203);
            this.GenderTitleLabel.Name = "GenderTitleLabel";
            this.GenderTitleLabel.Size = new System.Drawing.Size(42, 13);
            this.GenderTitleLabel.TabIndex = 6;
            this.GenderTitleLabel.Text = "Gender";
            // 
            // UserTypeTitleLabel
            // 
            this.UserTypeTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UserTypeTitleLabel.AutoSize = true;
            this.UserTypeTitleLabel.Location = new System.Drawing.Point(405, 255);
            this.UserTypeTitleLabel.Name = "UserTypeTitleLabel";
            this.UserTypeTitleLabel.Size = new System.Drawing.Size(52, 13);
            this.UserTypeTitleLabel.TabIndex = 7;
            this.UserTypeTitleLabel.Text = "User type";
            // 
            // AgeNumeric
            // 
            this.AgeNumeric.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AgeNumeric.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AgeNumeric.Location = new System.Drawing.Point(403, 168);
            this.AgeNumeric.Minimum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.AgeNumeric.Name = "AgeNumeric";
            this.AgeNumeric.Size = new System.Drawing.Size(197, 29);
            this.AgeNumeric.TabIndex = 8;
            this.AgeNumeric.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
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
            this.GenderComboBox.Location = new System.Drawing.Point(403, 219);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(197, 28);
            this.GenderComboBox.TabIndex = 9;
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
            this.UserTypeComboBox.Location = new System.Drawing.Point(403, 271);
            this.UserTypeComboBox.Name = "UserTypeComboBox";
            this.UserTypeComboBox.Size = new System.Drawing.Size(197, 28);
            this.UserTypeComboBox.TabIndex = 10;
            // 
            // DescriptionLinkedLabel
            // 
            this.DescriptionLinkedLabel.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.DescriptionLinkedLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DescriptionLinkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionLinkedLabel.LinkColor = System.Drawing.Color.Black;
            this.DescriptionLinkedLabel.Location = new System.Drawing.Point(325, 303);
            this.DescriptionLinkedLabel.Name = "DescriptionLinkedLabel";
            this.DescriptionLinkedLabel.Size = new System.Drawing.Size(150, 35);
            this.DescriptionLinkedLabel.TabIndex = 11;
            this.DescriptionLinkedLabel.TabStop = true;
            this.DescriptionLinkedLabel.Text = "Add description";
            this.DescriptionLinkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DescriptionLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DescriptionLinkedLabel_LinkClicked);
            // 
            // SinginButton
            // 
            this.SinginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SinginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SinginButton.Location = new System.Drawing.Point(328, 365);
            this.SinginButton.Name = "SinginButton";
            this.SinginButton.Size = new System.Drawing.Size(150, 35);
            this.SinginButton.TabIndex = 12;
            this.SinginButton.Text = "Sing in";
            this.SinginButton.UseVisualStyleBackColor = true;
            this.SinginButton.Click += new System.EventHandler(this.SinginButton_Click);
            // 
            // SinginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.SinginButton);
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
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SinginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Singin";
            ((System.ComponentModel.ISupportInitialize)(this.AgeNumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label NameTitleLabel;
        private System.Windows.Forms.Label PasswordTitleLabel;
        private System.Windows.Forms.Label EmailTitleLabel;
        private System.Windows.Forms.Label AgeTitleLabel;
        private System.Windows.Forms.Label GenderTitleLabel;
        private System.Windows.Forms.Label UserTypeTitleLabel;
        private System.Windows.Forms.NumericUpDown AgeNumeric;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.ComboBox UserTypeComboBox;
        private System.Windows.Forms.LinkLabel DescriptionLinkedLabel;
        private System.Windows.Forms.Button SinginButton;
    }
}