using App.Shared.Domain;

namespace App.Domain.OrderAggregate
{
    public interface IPaymentGateway
    {
        void Pay(decimal price, string method, string methodData);
    }
}
