using System;
using Facade.Interfaces;

namespace Facade.Inventory
{
    class OrderVerificationManager : IOrderVerify
    {
        public bool VerifyShippingAddress(int pincode)
        {
            Console.WriteLine(string.Format("The product can be shipped to the pincode {0}.", pincode));
            return true;
        }
    }
}
