using App.Shared.Domain.Exception;

namespace App.Domain.CartAggregate.Exception
{
    public class InvalidCartAttributeException : InvalidAttributeException
    {
        public InvalidCartAttributeException(string message): base(message){}
    }
}
