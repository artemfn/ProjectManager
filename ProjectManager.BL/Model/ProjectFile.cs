using System;
using System.IO;

namespace ProjectManager.BL.Model
{
    [Serializable]
    public abstract class ProjectFile
    {
        public ProjectFile(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            Path = path;
        }


        public string Path { get; }


        public abstract void Save();
        public abstract void Open();
        public abstract void Close();

        public void Delete()
        {
            if (File.Exists(Path))
            {
                
                File.Delete(Path);
            }
            else
            {
                throw new InvalidOperationException(nameof(Delete));
            }
        }

        public void TryDelete()
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
        }
    }
}