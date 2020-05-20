using System;

namespace Directos.Module3.Ejercicio5.Utils
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