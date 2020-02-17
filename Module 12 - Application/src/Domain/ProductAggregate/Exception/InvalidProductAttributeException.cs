using App.Shared.Domain.Exception;

namespace App.Domain.ProductAggregate.Exception
{
    public class InvalidProductAttributeException : InvalidAttributeException
    {
        public InvalidProductAttributeException(string message): base(message){}
    }
}
