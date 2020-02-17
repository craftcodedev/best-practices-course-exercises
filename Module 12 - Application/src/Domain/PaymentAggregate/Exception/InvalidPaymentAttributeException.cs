using App.Shared.Domain.Exception;

namespace App.Domain.PaymentAggregate.Exception
{
    public class InvalidPaymentAttributeException : InvalidAttributeException
    {
        public InvalidPaymentAttributeException(string message): base(message){}
    }
}
