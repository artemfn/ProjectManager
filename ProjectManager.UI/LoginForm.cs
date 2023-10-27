using System;
using System.IO;
using System.Windows.Forms;
using ProjectManager.BL.Data;
using ProjectManager.BL.Model;

namespace ProjectManager.UI
{
    public partial class LoginForm : Form
    {
        private const string USERSDIRECTORYPATH = @"C:\Users\Admin\Desktop\Projects.cs\ProjectManager\ProjectManager.UI\bin\Debug\users";

        private readonly BinarySerializationProvider _serializationProvider = new BinarySerializationProvider();
        private readonly DirectoryController _directoryController = new DirectoryController();

        private User _user;


        public LoginForm()
        {
            InitializeComponent();

            _directoryController.TryCreate("users");
        }


        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(NameTextBox.Text) &&
                !string.IsNullOrEmpty(PasswordTextBox.Text))
            {
                if (File.Exists($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}"))
                {
                    var tempUser = _serializationProvider.Load<User>($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}");

                    if (tempUser != null && tempUser.Password == PasswordTextBox.Text)
                    {
                        ///
                    }
                    else
                    {
                        MessageBox.Show("User did not find!", "Login");
                    }
                }
                else
                {
                    MessageBox.Show("User did not find!", "Login");
                }
            }
        }

        private void SinginLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            new SinginForm().ShowDialog();
            Close();
        }
    }
}