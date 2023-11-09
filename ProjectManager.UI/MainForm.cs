using Microsoft.Office.Core;
using ProjectManager.BL.Data;
using ProjectManager.BL.Model;
using ProjectManager.UI.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProjectManager.UI
{
    public partial class MainForm : Form
    {
        private readonly BinarySerializationProvider _serializationProvider = new BinarySerializationProvider();
        private readonly User _user;


        public MainForm(User user)
        {
            InitializeComponent();

            _user = user ??
                throw new ArgumentNullException(nameof(user));

            ProjectsListBox.Items.AddRange(_user.Projects.ToArray());
        }

        #region project
        private void CreateProjectMenuItem_Click(object sender, EventArgs e)
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
        private void DeleteProjectMenuItem_Click(object sender, EventArgs e)
        {
            var selected = ProjectsListBox.SelectedItem as Project;

            if (selected != null)
            {
                if (MessageBox.Show("Do you really want to delete the project?", "ProjectManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
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
        }
        private void OpenProjectMenuItem_Click(object sender, EventArgs e)
        {
            var selected = ProjectsListBox.SelectedItem as Project;

            if (selected != null)
            {
                UpdateFilesUIState(selected.FullPath);
            }
        }
        #endregion

        #region file
        private void OpenFileButton_Click(object sender, EventArgs e, string path)
        {
            ProjectFile file;

            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            var type = path.Substring(path.Length - 4);

            if (type == "docx")
                file = new WordFile(path, true);

            else if (type == "xlsx")
                file = new ExcelFile(path, true);

            else if (type == "pptx")
                file = new PowerPointFile(path, MsoTriState.msoTrue);

            else
                throw new InvalidDataException(nameof(path));

            using (file)
            {
                file.Open();
            }
        }
        private void DeleteFileButton_Click(object sender, EventArgs e, string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (MessageBox.Show("Do you really want to delete the file?", "ProjectManager", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (File.Exists(path))
                {
                    File.Delete(path);

                    UpdateFilesUIState(new FileInfo(path).Directory.FullName);
                }
            }
        }
        private void AddWordFileMenuItem_Click(object sender, EventArgs e)
        {
            var selected = ProjectsListBox.SelectedItem as Project;

            if (selected != null)
            {
                var form = new AddProjectFileForm("Microsoft Word", Resources.WordLogo);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var file = new WordFile(form.ProjectFileName, selected.FullPath, false))
                    {
                        file.Save();
                    }

                    UpdateFilesUIState(selected.FullPath);
                }
            }
        }
        private void AddExcelFileMenuItem_Click(object sender, EventArgs e)
        {
            var selected = ProjectsListBox.SelectedItem as Project;

            if (selected != null)
            {
                var form = new AddProjectFileForm("Microsoft Excel", Resources.ExcelLogo);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var file = new ExcelFile(form.ProjectFileName, selected.FullPath, false))
                    {
                        file.Save();
                    }

                    UpdateFilesUIState(selected.FullPath);
                }
            }
        }
        private void AddPowerPointFileMenuItem_Click(object sender, EventArgs e)
        {
            var selected = ProjectsListBox.SelectedItem as Project;

            if (selected != null)
            {
                var form = new AddProjectFileForm("Microsoft PowerPoint", Resources.PowerPointLogo);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    using (var file = new PowerPointFile(form.ProjectFileName, selected.FullPath, MsoTriState.msoFalse))
                    {
                        file.Save();
                    }

                    UpdateFilesUIState(selected.FullPath);
                }
            }
        }
        #endregion


        private void UpdateFilesUIState(string directoryPath)
        {
            string[] validPaths = Directory.GetFiles(directoryPath)
                                           .Where(file => !Path.GetFileName(file)
                                           .StartsWith("~$"))
                                           .ToArray();

            MainProjectFilesPanel.Controls.Clear();

            foreach (var path in validPaths)
            {
                var view = new ProjectFileView(Path.GetFileName(path), GetProjectFileLogo(path));

                view.OpenButton.Click += (s, a) => OpenFileButton_Click(s, a, path);
                view.DeleteButton.Click += (s, a) => DeleteFileButton_Click(s, a, path);
                view.BackgroundPanel.DoubleClick += (s, a) => OpenFileButton_Click(s, a, path);

                MainProjectFilesPanel.Controls.Add(view.BackgroundPanel);
            }
        }
        private Bitmap GetProjectFileLogo(string name)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            var type = name.Substring(name.Length - 4);

            if (type == "docx")
                return Resources.WordLogo;

            else if (type == "xlsx")
                return Resources.ExcelLogo;

            else if (type == "pptx")
                return Resources.PowerPointLogo;

            else
                throw new InvalidDataException(nameof(name));
        }

        private void ProfileMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}