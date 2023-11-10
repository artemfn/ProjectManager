using ProjectManager.BL.Data;
using ProjectManager.BL.Model;
using System;
using System.Windows.Forms;

namespace ProjectManager.UI
{
    public partial class ProfileForm : Form
    {
        private readonly User _user;
        private readonly DescriptionForm _descriptionForm;


        public ProfileForm(User user)
        {
            InitializeComponent();

            _user = user ??
                throw new ArgumentNullException(nameof(user));

            _descriptionForm = new DescriptionForm(_user.Description);

            NameTextBox.Text = user.Name;
            PasswordTextBox.Text = user.Password;
            EmailTextBox.Text = user.Email;
            AgeNumeric.Value = user.Age;
            GenderComboBox.Text = user.Gender;
            UserTypeComboBox.Text = user.UserType;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _user.Set(NameTextBox.Text, PasswordTextBox.Text, EmailTextBox.Text,
                      GenderComboBox.Text, (int)AgeNumeric.Value,
                      _descriptionForm.GetDescription(), UserTypeComboBox.Text);
        }

        public User GetChangedUserModel()
        {
            return _user;
        }

        private void DescriptionLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _descriptionForm.ShowDialog();
        }
    }
}