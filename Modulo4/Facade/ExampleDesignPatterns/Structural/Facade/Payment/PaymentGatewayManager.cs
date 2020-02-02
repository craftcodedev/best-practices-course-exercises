using System;
using Facade.Interfaces;

namespace Facade.Inventory
{
    class PaymentGatewayManager : IPaymentGateway
    {
        public bool VerifyCardDetails(string cardNo)
        {
            Console.WriteLine(string.Format("Card# {0} has been verified and is accepted.",
                cardNo));
            return true;
        }

        public bool ProcessPayment(string cardNo, float cost)
        {
            Console.WriteLine(string.Format("Card# {0} is used to make a payment of {1}.",cardNo,cost));
            return true;
        }
    }
}
