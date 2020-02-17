using App.Domain.PaymentAggregate;

namespace App.Infrastructure.Service.PaymentService
{
    public class PaymentFactory : IPaymentFactory
    {
        public Payment Create(string id, decimal price, string method, string orderId, string customerId)
        {
            PaymentId paymentId = new PaymentId(id);
            PaymentPrice paymentPrice = new PaymentPrice(price);
            PaymentMethod paymentMethod = new PaymentMethod(method);
            PaymentOrderId paymentOrderId = new PaymentOrderId(orderId);
            PaymentCustomerId paymentCustomerId = new PaymentCustomerId(customerId);

            return Payment.Create(paymentId, paymentPrice, paymentMethod, paymentOrderId, paymentCustomerId);
        }
    }
}