using App.Shared.Domain;
using App.Domain.PaymentAggregate.Exception;

namespace App.Domain.PaymentAggregate
{
    public class PaymentPrice : DecimalValueObject
    {
        public PaymentPrice(decimal value) : base(value)
        {
            if (value.Equals(0)) {
                throw InvalidPaymentAttributeException.FromEmpty("price");
            }
        }
    }
}