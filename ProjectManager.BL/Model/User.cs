using System;
using System.Collections.Generic;
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
        public int Gender { get; private set; } // man - 1
                                                // woman - -1
                                                // other - 0
        public string Description { get; private set; }
        public UserType UserType { get; private set; }
        public List<Project> Projects { get; private set; }


        public void Set(string name, string password, string email,
                        int gender, int age, string description,
                        UserType type)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentNullException(nameof(name));

            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException(nameof(password));

            if (string.IsNullOrEmpty(email))
                throw new ArgumentNullException(nameof(email));

            if (gender > 1 || gender < -1)
                throw new ArgumentOutOfRangeException(nameof(gender));

            if (age > 100 || age < 12)
                throw new ArgumentOutOfRangeException(nameof(age));

            if (string.IsNullOrEmpty(description))
                throw new ArgumentNullException(nameof(description));

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