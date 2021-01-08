namespace elearning.Shared.Domain.Exception
{
    public class ErrorException : Exception
    {
        public ErrorException(string message) : base(message) { }
    }
}