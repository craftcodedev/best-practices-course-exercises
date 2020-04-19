using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects
{
    public class Course
    {
        private string name;

        public Course(string name)
        {
            if (name == "")
            {
                throw new System.Exception("Invalid name");
            }

            this.name = name;
        }

        public string Name()
        {
            return this.name;
        }

        public string Description()
        {
            this.name = "You will learn " + this.name;
            return this.name;
        }
    }
}
