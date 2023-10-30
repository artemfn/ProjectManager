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
                if (File.Exists($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}\Data"))
                {
                    var user = _serializationProvider.Load<User>($@"{USERSDIRECTORYPATH}\{NameTextBox.Text}\Data");

                    if (user != null && user.Password == PasswordTextBox.Text)
                    {
                        Hide();
                        new MainMenuForm(user).ShowDialog();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("User did not find!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("User did not find!", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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