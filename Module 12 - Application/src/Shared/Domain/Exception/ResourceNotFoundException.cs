namespace App.Shared.Domain.Exception
{
    public class ResourceNotFoundException : ValidationException
    {
        public ResourceNotFoundException(string message): base(message){}
    }
}
