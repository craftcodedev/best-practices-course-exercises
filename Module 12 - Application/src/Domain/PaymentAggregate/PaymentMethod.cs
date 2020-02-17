using App.Shared.Domain;
using App.Domain.PaymentAggregate.Exception;

namespace App.Domain.PaymentAggregate
{
    public class PaymentMethod : StringValueObject
    {
        public const string PAYPAL_METHOD = "paypal";
        public const string CREDITCARD_METHOD = "creditcard";

        public PaymentMethod(string value) : base(value)
        {
            if (value != PaymentMethod.PAYPAL_METHOD && value != PaymentMethod.CREDITCARD_METHOD) {
                throw InvalidPaymentAttributeException.FromValue("status", value);
            }
        }
    }
}