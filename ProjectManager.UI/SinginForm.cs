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

        private bool _isDescriptionAdded = false;
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
                _isDescriptionAdded = true;
                _description = descriptionForm.GetDescription(_isDescriptionAdded);
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
                    GetGenderValue(GenderComboBox.Text), (int)AgeNumeric.Value, _description, GetUserTypeValue(UserTypeComboBox.Text));

                _directoryController.TryCreate($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}");
                _directoryController.TryCreate($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}\Projects");
                _serializationProvider.Save($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}\Data", _user);

                MessageBox.Show("User did sing in!", "Singin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                new MainForm(_user).ShowDialog();
                Close();
            }
        }

        private int GetGenderValue(string gender)
        {
            if (string.IsNullOrEmpty(gender)) 
                throw new ArgumentNullException(nameof(gender));

            if (gender == "Man")
                return 1;
            else if (gender == "Women")
                return -1;
            else
                return 0;
        }

        private UserType GetUserTypeValue(string type)
        {
            if (string.IsNullOrEmpty(type))
                throw new ArgumentNullException(nameof(type));

            if (type == "Ordinary")
                return UserType.Ordinary;
            else if (type == "Student")
                return UserType.Student;
            else if (type == "Teacher")
                return UserType.Teacher;
            else if (type == "Company")
                return UserType.Company;
            else
                return UserType.Other;
        }
    }
}