using App.Shared.Domain.Exception;

namespace App.Domain.CustomerAggregate.Exception
{
    public class InvalidCustomerAttributeException : InvalidAttributeException
    {
        public InvalidCustomerAttributeException(string message): base(message){}
    }
}
