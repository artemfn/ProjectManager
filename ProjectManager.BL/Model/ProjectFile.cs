using System;
using System.IO;

namespace ProjectManager.BL.Model
{
    public abstract class ProjectFile
    {
        public ProjectFile(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            Path = path;
        }


        protected string Path { get; }


        public abstract void Save();
        public abstract void Open();

        public void TryDelete()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }
    }
}