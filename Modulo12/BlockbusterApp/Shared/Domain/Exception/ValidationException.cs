using System;
namespace BlockbusterApp.src.Shared.Domain.Exception
{
    public class ValidationException : WarningException
    {
        public ValidationException(string message) : base(message) { }
    }
}
