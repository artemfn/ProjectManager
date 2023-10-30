using ProjectManager.BL.Model;
using System.Windows.Forms;
using System;
using ProjectManager.BL.Data;
using System.Linq;

namespace ProjectManager.UI
{
    public partial class MainMenuForm : Form
    {
        private readonly BinarySerializationProvider _serializationProvider = new BinarySerializationProvider();
        private readonly User _user;


        public MainMenuForm(User user)
        {
            InitializeComponent();

            _user = user ??
                throw new ArgumentNullException(nameof(user));

            ProjectsListBox.Items.AddRange(_user.Projects.ToArray());
        }

        private void DeleteProjectButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete the project", "ProjectManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var selected = ProjectsListBox.SelectedItem as Project;

                if (_user.Projects.Exists(s => s == selected))
                {
                    _user.Projects.Remove(selected);
                    selected.TryDelete();

                    _serializationProvider.SaveOrReplace($@"C:\Users\Admin\Desktop\Projects.cs\ProjectManager\ProjectManager.UI\bin\Debug\users\{_user.Name}\Data", _user);

                    ProjectsListBox.Items.Clear();
                    ProjectsListBox.Items.AddRange(_user.Projects.ToArray());
                }
                else
                {
                    throw new InvalidOperationException();
                }
            }
        }

        private void AddProjectButton_Click(object sender, EventArgs e)
        {
            var form = new CreateProjectForm();

            if (form.ShowDialog() == DialogResult.OK)
            {
                var project = new Project($@"C:\Users\Admin\Desktop\Projects.cs\ProjectManager\ProjectManager.UI\bin\Debug\users\{_user.Name}\Projects",
                    form.ProjectName,
                    form.ProjectDescription);

                _user.Projects.Add(project);

                _serializationProvider.SaveOrReplace($@"C:\Users\Admin\Desktop\Projects.cs\ProjectManager\ProjectManager.UI\bin\Debug\users\{_user.Name}\Data", _user);

                ProjectsListBox.Items.Clear();
                ProjectsListBox.Items.AddRange(_user.Projects.ToArray());
            }
        }
    }
}