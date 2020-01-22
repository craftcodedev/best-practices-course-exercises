using System;

namespace App.Model.User.ValueObject.Exception
{
    public class InvalidUserIdException : System.Exception
    {
        public InvalidUserIdException(string message): base(message){}

        public static void FromZero()
        {
            throw new InvalidUserIdException("user id is not valid");
        }
    }
}