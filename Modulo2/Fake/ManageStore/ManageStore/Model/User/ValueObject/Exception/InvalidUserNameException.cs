using System;

namespace App.Model.User.ValueObject.Exception
{
    public class InvalidUserNameException : System.Exception
    {
        public InvalidUserNameException(string message): base(message){}

        public static void FromEmpty()
        {
            throw new InvalidUserNameException("user name is empty");
        }

        public static void FromMaxLength()
        {
            throw new InvalidUserNameException("user name cannot be longer than 15 characters");
        }
    }
}