using System.Collections.Generic;

namespace ProjectManager.BL.Model
{
    public class User
    {
        public string Name { get; private set; }
        public string Password { get; private set; }
        public string Email { get; private set; }
        public int Age { get; private set; }
        public int Gender { get; private set; }
        public UserType UserType { get; private set; }
        public List<Project> Projects { get; private set; }


        public override string ToString()
        {
            return Name;
        }
    }
}