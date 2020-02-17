using App.Shared.Domain;

namespace App.Domain.PaymentAggregate
{
    public class PaymentId : UUID
    {
        public PaymentId(string value) : base(value) {}
    }
}