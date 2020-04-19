using System;
using System.Collections.Generic;
using System.Text;

namespace ValueObjects
{
    class InvalidCourseNameException : Exception
    {
        public InvalidCourseNameException(string message) : base(message)
        {

        }

        public static InvalidCourseNameException FromEmpty()
        {
            return new InvalidCourseNameException("Invalid name");
        }
    }
}
