using System;
using Facade.Interfaces;

namespace Facade.Inventory
{
    class LogisticsManager : ILogistics
    {
        public void ShipProduct(string productName, string shippingAddress)
        {
            Console.WriteLine(string.Format("Congratulations your product {0} has been shipped at the following address: {1}", 
                productName, shippingAddress));
        }
    }
}
