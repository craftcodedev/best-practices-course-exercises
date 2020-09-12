using System;
namespace BlockbusterApp.src.Shared.Domain.Exception
{
    public class Exception : System.Exception
    {
        public Exception(string message) : base(message) { }
    }
}
