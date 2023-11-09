using System;
using System.IO;

namespace ProjectManager.BL.Model
{
    [Serializable]
    public abstract class ProjectFile : IDisposable
    {
        public ProjectFile(string name, string path)
        { 
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            Name = name;
            Path = path;
            FullPath = $@"{Path}\{Name}";
        }

        public ProjectFile(string fullPath)
        {
            if (string.IsNullOrEmpty(fullPath))
                throw new ArgumentNullException(nameof(fullPath));

            FullPath = fullPath;
        }


        public string Name { get; }
        public string Path { get; }
        public string FullPath { get; }


        public abstract void Save();
        public abstract void Open();
        public abstract void Dispose();

        public void Delete()
        {
            if (File.Exists(FullPath))
            {
                
                File.Delete(FullPath);
            }
            else
            {
                throw new InvalidOperationException(nameof(Delete));
            }
        }

        public void TryDelete()
        {
            if (File.Exists(FullPath))
            {
                File.Delete(FullPath);
            }
        }
    }
}