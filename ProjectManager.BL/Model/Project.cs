using System.Collections.Generic;
using System;
using System.IO;

namespace ProjectManager.BL.Model
{
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

            CreateDirectory(DirectoryPath);
        }


        public string Path { get; }
        public string Name { get; }
        public string Description { get; }

        private string DirectoryPath => $"{Path}\\{Name}";


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

        public void Delete()
        {
            foreach (var file in _files)
            {
                file.TryDelete();
            }
        }

        private void CreateDirectory(string path)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            else
            {
                throw new InvalidOperationException(nameof(path));
            }
        }
    }
}