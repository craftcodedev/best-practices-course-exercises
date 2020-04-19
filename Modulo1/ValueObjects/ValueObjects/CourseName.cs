using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects
{
    public class CourseName
    {
        private string value;

        public CourseName(string value)
        {
            if(value == "")
            {
                InvalidCourseNameException.FromEmpty();
            }

            this.value = value;
        }

        public string Value()
        {
            return value;
        }
    }
}
