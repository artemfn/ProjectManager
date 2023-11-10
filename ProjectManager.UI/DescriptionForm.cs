using System.Windows.Forms;

namespace ProjectManager.UI
{
    public partial class DescriptionForm : Form
    {
        private string _description;


        public DescriptionForm(string description = null)
        {
            InitializeComponent();

            if (description != null)
            {
                DescriptionTextBox.Text = description;
                _description = description;
            }
        }


        public string GetDescription()
        {
            return _description;
        }

        private void AddDescriptionButton_Click(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                _description = DescriptionTextBox.Text;
            }
        }
    }
}