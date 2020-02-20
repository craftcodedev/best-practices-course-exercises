using System;
namespace CraftCodeApp.src.Shared.Domain.Exception
{
    public class InvalidttributeException : WarningException
    {
        public InvalidttributeException(string message) : base(message) { }
    }
}