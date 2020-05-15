using System;

namespace Module2.Ejercicio2.Utils
{
    public class Module
    {
        private string id;
        private string courseId;

        public Module(string id, string courseId)
        {
            this.id = id;
            this.courseId = courseId;
        }

        public string Id()
        {
            return this.id;
        }

        public string CourseId()
        {
            return this.courseId;
        }
    }
}