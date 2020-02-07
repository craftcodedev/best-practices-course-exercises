using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();

            var customer = new Customer
            {
                ID = 1,
                LastName = "Lopez",
                Name = "Raul",
                MemberShip = new StandardMemberShip()
            };

            var customer2 = new Customer
            {
                ID = 1,
                LastName = "Lopez",
                Name = "Raul",
                MemberShip = new PremiumMemberShip()
            };

            var price = order.CalculatePrice(10, customer);
            var price2 = order.CalculatePrice(10, customer2);
        }
    }
}
