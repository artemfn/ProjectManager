namespace ProjectManager.UI
{
    partial class DescriptionForm
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
            this.DescriptionTextBox = new System.Windows.Forms.RichTextBox();
            this.AddDescriptionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DescriptionTextBox.Location = new System.Drawing.Point(0, 0);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(682, 394);
            this.DescriptionTextBox.TabIndex = 0;
            this.DescriptionTextBox.Text = "";
            // 
            // AddDescriptionButton
            // 
            this.AddDescriptionButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddDescriptionButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddDescriptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDescriptionButton.Location = new System.Drawing.Point(12, 400);
            this.AddDescriptionButton.Name = "AddDescriptionButton";
            this.AddDescriptionButton.Size = new System.Drawing.Size(660, 35);
            this.AddDescriptionButton.TabIndex = 7;
            this.AddDescriptionButton.Text = "Add";
            this.AddDescriptionButton.UseVisualStyleBackColor = true;
            this.AddDescriptionButton.Click += new System.EventHandler(this.AddDescriptionButton_Click);
            // 
            // DescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 441);
            this.Controls.Add(this.AddDescriptionButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "DescriptionForm";
            this.Text = "Description";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox DescriptionTextBox;
        private System.Windows.Forms.Button AddDescriptionButton;
    }
}