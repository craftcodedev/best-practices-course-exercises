namespace elearning.Shared.Domain.Exception
{
    public class ResourceNotFoundException : WarningException
    {
        public ResourceNotFoundException(string message) : base(message) { }
    }
}