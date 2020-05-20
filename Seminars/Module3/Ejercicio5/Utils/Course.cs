using System;
using System.Collections.Generic; 

namespace Directos.Module3.Ejercicio5.Utils
{
    public class Course
    {
        private string id;
        private string status;
        private List<Teacher> teachers;

        public Course(string id, string status, List<Teacher> teachers)
        {
            this.id = id;
            this.status = status;
            this.teachers = teachers;
        }

        private static Course Create(string id, string status, List<Teacher> teachers)
        {
            return new Course(id, status, teachers);
        }

        public string Id()
        {
            return this.id;
        }

        public string Status()
        {
            return this.status;
        }

        public List<Teacher> Teachers()
        {
            return this.teachers;
        }
    }
}