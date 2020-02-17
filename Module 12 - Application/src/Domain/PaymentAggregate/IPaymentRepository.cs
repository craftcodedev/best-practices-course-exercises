using App.Domain.PaymentAggregate;

namespace App.Domain.PaymentAggregate
{
    public interface IPaymentRepository
    {
        void Save(Payment payment);
    }
}
