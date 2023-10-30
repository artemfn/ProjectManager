using System.Windows.Forms;

namespace ProjectManager.UI
{
    public partial class CreateProjectForm : Form
    {
        public CreateProjectForm()
        {
            InitializeComponent();
        }


        public string ProjectName { get; private set; }
        public string ProjectDescription { get; private set; }

        private void CreateButton_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                ProjectName = NameTextBox.Text;
                ProjectDescription = DescriptionTextBox.Text;
            }
        }
    }
}