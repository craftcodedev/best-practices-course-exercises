using App.Domain;

namespace App.Infrastructure.Service.PaymentGateway
{
    public class WCard : IPaymentGatewayAPI
    {
        private string number;
        private string expiration;
        private string type;
        private string securityCode;

        public WCard(string number, string expiration, string type, string securityCode)
        {
            //EField
        }
        
        public void Pay(decimal price)
        {
            
        }
    }
}
