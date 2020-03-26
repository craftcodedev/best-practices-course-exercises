using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    public class Order
    {
        public decimal CalculatePrice(decimal price, Customer customer)
        {
            return customer.MemberShip.CalculatePrice(price);
        }
    }
}
