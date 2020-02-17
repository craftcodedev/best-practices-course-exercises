using App.Domain.OrderAggregate;

namespace App.Infrastructure.Service.PaymentGateway
{
    public class PaymentGateway : IPaymentGateway
    {
        private PaymentGatewayAPIFactory paymentGatewayAPIFactory;

        public PaymentGateway(PaymentGatewayAPIFactory paymentGatewayAPIFactory)
        {
            this.paymentGatewayAPIFactory = paymentGatewayAPIFactory;
        }
        public void Pay(decimal price, string method, string methodData)
        {
            IPaymentGatewayAPI paymentGatewayApi = this.paymentGatewayAPIFactory.Create(method, methodData);

            paymentGatewayApi.Pay(price);
        }
    }
}