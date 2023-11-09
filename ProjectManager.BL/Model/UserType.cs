using System;

namespace ProjectManager.BL.Model
{
    [Serializable]
    public enum UserType
    {
        None = -1,
        Ordinary,
        Student,
        Teacher,
        Company,
        Other
    }
}