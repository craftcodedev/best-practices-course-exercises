using System;
namespace BlockbusterApp.src.Shared.Domain.Exception
{
    public class InvalidAttributeException : ValidationException
    {
        public InvalidAttributeException(string message) : base(message) { }

        public static InvalidAttributeException FromText(string text)
        {
            return new InvalidAttributeException(text);
        }

        public static InvalidAttributeException FromEmpty(string attribute)
        {
            return new InvalidAttributeException(string.Format("the {0} must not be empty", attribute));
        }

        public static InvalidAttributeException FromValue(string attribute, string value)
        {
            return new InvalidAttributeException(string.Format("the {0} is invalid because of its value {1}", attribute, value));
        }

        public static InvalidAttributeException FromMaxLength(string attribute, int length)
        {
            return new InvalidAttributeException(string.Format("length {0} cannot be more than {1} characters.", attribute, length.ToString()));
        }

        public static InvalidAttributeException FromMinLength(string attribute, int length)
        {
            return new InvalidAttributeException(string.Format("length {0} cannot be less than {1} characters.", attribute, length.ToString()));
        }
    }
}
