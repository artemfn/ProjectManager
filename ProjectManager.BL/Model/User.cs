using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace ProjectManager.BL.Model
{
    [Serializable]
    public class User
    {
        public User()
        {
            Projects = new List<Project>();
        }


        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public int Age { get; private set; }
        public string Gender { get; private set; }
        public string Description { get; private set; }
        public string UserType { get; private set; }
        public List<Project> Projects { get; private set; }


        public void Set(string name, string password, string email,
                        string gender, int age, string description,
                        string type)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException(nameof(password));

            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException(nameof(email));

            if (string.IsNullOrEmpty(gender))
                throw new ArgumentNullException(nameof(gender));

            if (age > 100 || age < 12)
                throw new ArgumentOutOfRangeException(nameof(age));

            if (string.IsNullOrEmpty(description))
                throw new ArgumentNullException(nameof(description));

            if (string.IsNullOrEmpty(type))
                throw new ArgumentNullException(nameof(type));

            Name = name;
            Password = password;
            Email = email;
            Gender = gender;
            Age = age;
            Description = description;
            UserType = type;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}