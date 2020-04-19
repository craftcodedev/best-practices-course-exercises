using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects
{
    public class Course
    {
        private CourseName name;

        public Course(CourseName name)
        {
            this.name = name;
        }

        public CourseName Name()
        {
            return this.name;
        }
    }
}
