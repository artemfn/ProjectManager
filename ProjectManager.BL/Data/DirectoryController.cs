using System.IO;
using System;

namespace ProjectManager.BL.Data
{
    public sealed class DirectoryController
    {
        public void TryCreate(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
        }

        public void Delete(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }
            else
            {
                throw new InvalidOperationException(nameof(path));
            }
        }

        public void TryDelete(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (Directory.Exists(path))
            {
                foreach (var file in Directory.GetFiles(path))
                {
                    File.Delete(file);
                }

                Directory.Delete(path);
            }
        }
    }
}