using System;
namespace CraftCodeApp.src.Shared.Domain.Exception
{
    public class WarningException : Exception
    {
        public WarningException(string message) : base(message) { }
    }
}