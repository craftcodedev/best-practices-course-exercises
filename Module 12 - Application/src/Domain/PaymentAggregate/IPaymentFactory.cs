namespace App.Domain.PaymentAggregate
{
    public interface IPaymentFactory
    {
        Payment Create(string id, decimal price, string method, string orderId, string customerId);
    }
}