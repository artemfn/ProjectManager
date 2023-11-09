using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System;

namespace ProjectManager.UI
{
    internal class ProjectFileView : IEnumerable<Control>
    {
        public ProjectFileView(string projectFileName, Bitmap projectFileLogo)
        {
            if (string.IsNullOrEmpty(projectFileName))
                throw new ArgumentNullException(nameof(projectFileName));

            if (projectFileLogo == null)
                throw new ArgumentNullException(nameof(projectFileLogo));

            BackgroundPanel = new Panel();
            LogoPictureBox = new PictureBox();
            NameLabel = new Label();
            OpenButton = new Button();
            DeleteButton = new Button();

            InitializeComponent(projectFileName, projectFileLogo);
        }


        public Panel BackgroundPanel { get; }
        public PictureBox LogoPictureBox { get; }
        public Label NameLabel { get; }
        public Button OpenButton { get; }
        public Button DeleteButton { get; }


        public IEnumerator<Control> GetEnumerator()
        {
            yield return BackgroundPanel;
            yield return LogoPictureBox;
            yield return NameLabel;
            yield return OpenButton;
            yield return DeleteButton;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private void InitializeComponent(string projectFileName, Bitmap projectFileLogo)
        {
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Image = projectFileLogo;
            LogoPictureBox.Location = new Point(3, 3);
            LogoPictureBox.Name = $"ProjectFileLogoPictureBox_{projectFileName}";
            LogoPictureBox.Size = new Size(131, 119);
            LogoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LogoPictureBox.TabIndex = 0;
            LogoPictureBox.TabStop = false;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            NameLabel.Location = new Point(140, 7);
            NameLabel.Name = $"ProjectFileNameLabel_{projectFileName}";
            NameLabel.Size = new Size(55, 20);
            NameLabel.TabIndex = 1;
            NameLabel.Text = projectFileName;
            // 
            // DeleteButton
            // 
            DeleteButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            DeleteButton.Location = new Point(695, 92);
            DeleteButton.Name = $"DeleteProjectFileButton_{projectFileName}";
            DeleteButton.Size = new Size(85, 25);
            DeleteButton.TabIndex = 0;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Visible = true;
            // 
            // OpenButton
            // 
            OpenButton.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OpenButton.Location = new Point(604, 92);
            OpenButton.Name = $"OpenProjectFileButton_{projectFileName}";
            OpenButton.Size = new Size(85, 25);
            OpenButton.TabIndex = 0;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Visible = true;
            // 
            // BackgroundPanel
            // 
            BackgroundPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            BackgroundPanel.BackColor = SystemColors.Control;
            BackgroundPanel.Controls.Add(OpenButton);
            BackgroundPanel.Controls.Add(DeleteButton);
            BackgroundPanel.Controls.Add(LogoPictureBox);
            BackgroundPanel.Controls.Add(NameLabel);
            BackgroundPanel.Name = $"ProjectFilePanel_{projectFileName}";
            BackgroundPanel.Size = new Size(790, 125);
            BackgroundPanel.TabIndex = 0;
        }
    }
}