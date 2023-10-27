namespace ProjectManager.UI
{
    partial class LoginForm
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
            this.NameTitleLabel = new System.Windows.Forms.Label();
            this.PasswordTitleLabel = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SinginLinkedLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TitleLabel.Location = new System.Drawing.Point(0, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(784, 120);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Project Manager";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTextBox.Location = new System.Drawing.Point(200, 166);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(400, 29);
            this.NameTextBox.TabIndex = 1;
            this.NameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordTextBox.Location = new System.Drawing.Point(200, 217);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(400, 29);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameTitleLabel
            // 
            this.NameTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameTitleLabel.AutoSize = true;
            this.NameTitleLabel.Location = new System.Drawing.Point(203, 150);
            this.NameTitleLabel.Name = "NameTitleLabel";
            this.NameTitleLabel.Size = new System.Drawing.Size(35, 13);
            this.NameTitleLabel.TabIndex = 4;
            this.NameTitleLabel.Text = "Name";
            // 
            // PasswordTitleLabel
            // 
            this.PasswordTitleLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.PasswordTitleLabel.AutoSize = true;
            this.PasswordTitleLabel.Location = new System.Drawing.Point(203, 201);
            this.PasswordTitleLabel.Name = "PasswordTitleLabel";
            this.PasswordTitleLabel.Size = new System.Drawing.Size(53, 13);
            this.PasswordTitleLabel.TabIndex = 5;
            this.PasswordTitleLabel.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(325, 300);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(150, 35);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SinginLinkedLabel
            // 
            this.SinginLinkedLabel.ActiveLinkColor = System.Drawing.SystemColors.MenuHighlight;
            this.SinginLinkedLabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.SinginLinkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SinginLinkedLabel.LinkColor = System.Drawing.Color.Black;
            this.SinginLinkedLabel.Location = new System.Drawing.Point(325, 338);
            this.SinginLinkedLabel.Name = "SinginLinkedLabel";
            this.SinginLinkedLabel.Size = new System.Drawing.Size(150, 35);
            this.SinginLinkedLabel.TabIndex = 7;
            this.SinginLinkedLabel.TabStop = true;
            this.SinginLinkedLabel.Text = "Sing in";
            this.SinginLinkedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SinginLinkedLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SinginLinkedLabel_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.SinginLinkedLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTitleLabel);
            this.Controls.Add(this.NameTitleLabel);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TitleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label NameTitleLabel;
        private System.Windows.Forms.Label PasswordTitleLabel;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.LinkLabel SinginLinkedLabel;
    }
}