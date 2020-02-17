using App.Shared.Domain;

namespace App.Domain.PaymentAggregate
{
    public class PaymentCustomerId : UUID
    {
        public PaymentCustomerId(string value) : base(value) {}
    }
}