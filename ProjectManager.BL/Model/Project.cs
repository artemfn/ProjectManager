using System.Collections.Generic;
using System;
using System.IO;
using ProjectManager.BL.Data;

namespace ProjectManager.BL.Model
{
    [Serializable]
    public class Project
    {
        [NonSerialized] private DirectoryController _directoryController;

        private readonly List<ProjectFile> _files;


        public Project(string path, string name, string description)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(description))
                throw new ArgumentNullException(nameof(description));

            _directoryController = new DirectoryController();
            _files = new List<ProjectFile>();
            Path = path;
            Name = name;
            Description = description;

            TryCreateDirectory(FullPath);
        }


        public string Name { get; }
        public string Path { get; }
        public string Description { get; }

        public string FullPath => $@"{Path}\{Name}";


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

            _directoryController = new DirectoryController();
            _directoryController.TryDelete(FullPath);
        }

        private void TryCreateDirectory(string path)
        {
            _directoryController.TryCreate(path);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}