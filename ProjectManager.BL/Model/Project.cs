using System.Collections.Generic;
using System;
using System.IO;

namespace ProjectManager.BL.Model
{
    [Serializable]
    public class Project
    {
        private readonly List<ProjectFile> _files;


        public Project(string path, string name, string description)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(description))
                throw new ArgumentNullException(nameof(description));

            _files = new List<ProjectFile>();
            Path = path;
            Name = name;
            Description = description;

            TryCreateDirectory(DirectoryPath);
        }


        public string Path { get; }
        public string Name { get; }
        public string Description { get; }

        private string DirectoryPath => $@"{Path}\{Name}";


        public void Add(ProjectFile file)
        {
            if (file == null)
                throw new ArgumentNullException(nameof(file));

            _files.Add(file);
        }

        public void Remove(ProjectFile file)
        {
            if (file == null)
                throw new ArgumentNullException(nameof(file));

            _files.Remove(file);
        }

        public void TryDelete()
        {
            foreach (var file in _files)
            {
                if (File.Exists(file.Path))
                {
                    file.TryDelete();
                }
            }

            if (Directory.Exists(DirectoryPath))
            {
                Directory.Delete(DirectoryPath);
            }
        }

        private void TryCreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public override string ToString()
        {
            return Name;
        }
    }
}