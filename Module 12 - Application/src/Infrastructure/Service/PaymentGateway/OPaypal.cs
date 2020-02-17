using App.Domain;

namespace App.Infrastructure.Service.PaymentGateway
{
    public class OPayPal : IPaymentGatewayAPI
    {
        private string email;
        private string password;

        public OPayPal(string email, string password)
        {
            //EField
        }

        public void Pay(decimal price)
        {
            
        }
    }
}
