using App.Shared.Domain.Exception;

namespace App.Domain.OrderAggregate.Exception
{
    public class InvalidOrderAttributeException : InvalidAttributeException
    {
        public InvalidOrderAttributeException(string message): base(message){}
    }
}
