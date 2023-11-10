using System.Windows.Forms;
using System;
using ProjectManager.BL.Data;
using ProjectManager.BL.Model;

namespace ProjectManager.UI
{
    public partial class SinginForm : Form
    {
        private const string USERSDIRECTORYPATH = @"C:\Users\Admin\Desktop\Projects.cs\ProjectManager\ProjectManager.UI\bin\Debug\users";

        private readonly BinarySerializationProvider _serializationProvider = new BinarySerializationProvider();
        private readonly DirectoryController _directoryController = new DirectoryController();
        private readonly User _user = new User();

        private string _description;


        public SinginForm()
        {
            InitializeComponent();
        }

        private void DescriptionLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var descriptionForm = new DescriptionForm();

            if (descriptionForm.ShowDialog() == DialogResult.OK)
            {
                _description = descriptionForm.GetDescription();
            }
        }

        private void SinginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text) &&
                !string.IsNullOrEmpty(EmailTextBox.Text) &&
                !string.IsNullOrEmpty(AgeNumeric.Value.ToString()) &&
                !string.IsNullOrEmpty(GenderComboBox.Text) &&
                !string.IsNullOrEmpty(_description) &&
                !string.IsNullOrEmpty(UserTypeComboBox.Text))
            {
                _user.Set(NameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text,
                    GenderComboBox.Text, (int)AgeNumeric.Value, _description, UserTypeComboBox.Text);

                _directoryController.TryCreate($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}");
                _directoryController.TryCreate($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}\Projects");
                _serializationProvider.Save($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}\Data", _user);

                MessageBox.Show("User did sing in!", "Singin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                new MainForm(_user).ShowDialog();
                Close();
            }
        }
    }
}