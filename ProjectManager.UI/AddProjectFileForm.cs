using ProjectManager.BL.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectManager.UI
{
    public partial class AddProjectFileForm : Form
    {
        public AddProjectFileForm(string title, Bitmap fileLogo)
        {
            InitializeComponent();

            TitleLabel.Text = title ??
                throw new ArgumentNullException(nameof(title));

            ProjectFileLogoPictureBox.Image = fileLogo ??
                throw new ArgumentNullException(nameof(fileLogo));
        }


        public string ProjectFileName { get; private set; }


        private void AddProjectFileForm_Load(object sender, EventArgs e)
        {

        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text))
            {
                ProjectFileName = NameTextBox.Text;
            }
        }

    }
}