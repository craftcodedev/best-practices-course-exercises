namespace App.Infrastructure.Service.PaymentGateway
{
    public interface IPaymentGatewayAPI
    {
        void Pay(decimal price);
    }
}
