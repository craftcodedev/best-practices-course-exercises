namespace App.Infrastructure.Service.PaymentGateway
{
    public class PaymentGatewayAPIFactory
    {   
        public IPaymentGatewayAPI Create(string method, string methodData)
        {
            IPaymentGatewayAPI paymentGatewayAPI;

            switch (method) {
                case "paypal":
                    paymentGatewayAPI = new OPayPal("TODO", "TODO");
                    break;

                case "creditcard":
                    paymentGatewayAPI = new WCard("TODO", "TODO", "TODO", "TODO");
                    break;

                default:

                    paymentGatewayAPI = new WCard("TODO", "TODO", "TODO", "TODO");
                    //throw
                    break;
            }

            return paymentGatewayAPI;
        }
    }
}