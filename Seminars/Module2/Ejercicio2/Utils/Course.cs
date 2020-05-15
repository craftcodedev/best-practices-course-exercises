using System;

namespace Module2.Ejercicio2.Utils
{
    public class Course
    {
        private string id;
        private string status;

        public Course(string id, string status)
        {
            this.id = id;
            this.status = status;
        }

        public string Id()
        {
            return this.id;
        }

        public string Status()
        {
            return this.status;
        }
    }
}