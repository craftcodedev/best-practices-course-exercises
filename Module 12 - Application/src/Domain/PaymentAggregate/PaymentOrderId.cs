using App.Shared.Domain;

namespace App.Domain.PaymentAggregate
{
    public class PaymentOrderId : UUID
    {
        public PaymentOrderId(string value) : base(value) {}
    }
}