using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class OrderDetails
    {
        public int ProductNo { get; private set; }

        public string ProductName { get; private set; }
        public string ProductDescription { get; private set; }
        public float Price { get; set; }
        public float DiscountPercent { get; private set; }
        public string AddressLine1 { get; private set; }
        public string AddressLine2 { get; private set; }
        public int PinCode { get; private set; }
        public string CardNo { get; private set; }

        public OrderDetails(string productName, string prodDescription, float price,
            float discount, string addressLine1, string addressLine2,
            int pinCode, string cardNo)
        {
            this.ProductNo = new Random(1).Next(1, 100);
            this.ProductName = productName;
            this.ProductDescription = prodDescription;
            this.Price = price;
            this.DiscountPercent = discount;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.PinCode = pinCode;
            this.CardNo = cardNo;
        }
    }
}
