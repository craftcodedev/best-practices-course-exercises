using System;
using System.Collections.Generic;

namespace elearning.Shared.Domain
{
    public class AuthUser
    {
        public const string ROLE_STUDENT = "student";
        public const string ROLE_TEACHER = "teacher";
        public const string ROLE_ADMINISTRATOR = "administrator";
        public static readonly List<string> ROLES = new List<string> { ROLE_STUDENT, ROLE_TEACHER, ROLE_ADMINISTRATOR };

        public string Id { get; }
        public string Email { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public string Role { get; }


        public AuthUser(string id, string email, string firstName, string lastName, string role)
        {
            Id = id;
            Email = email;
            FirstName = firstName;
            LastName = lastName;
            Role = role;
        }

        public bool IsStudent()
        {
            return ROLES.Contains(ROLE_STUDENT);
        }

        public bool IsTeacher()
        {
            return ROLES.Contains(ROLE_TEACHER);
        }

        public bool IsAdministrator()
        {
            return ROLES.Contains(ROLE_ADMINISTRATOR);
        }

        public static bool Contains(string role)
        {
            return ROLES.Contains(role);
        }
    }
}