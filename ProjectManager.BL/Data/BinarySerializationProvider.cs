using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ProjectManager.BL.Data
{
    public sealed class BinarySerializationProvider
    {
        private readonly BinaryFormatter _formatter = new BinaryFormatter();


        public void Save<T>(string path, T obj)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                _formatter.Serialize(fs, obj);
            }
        }

        public T Load<T>(string path) where T : class
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            using (var fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                return _formatter.Deserialize(fs) as T;
            }
        }

        public void Delete(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentNullException(nameof(path));

            if (File.Exists(path))
            {
                File.Delete(path);
            }
            else
            {
                throw new InvalidOperationException(nameof(path));
            }
        }
    }
}