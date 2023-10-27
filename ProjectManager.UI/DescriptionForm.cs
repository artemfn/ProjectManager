using System.Windows.Forms;

namespace ProjectManager.UI
{
    public partial class DescriptionForm : Form
    {
        private string _description;


        public DescriptionForm()
        {
            InitializeComponent();
        }


        public string GetDescription(bool target)
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