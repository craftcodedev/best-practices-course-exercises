using Decorator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class PremiumOrder : OrderDecorator
    {
        public PremiumOrder(OrderBase orderBase) : base(orderBase)
        {

        }

        public override double CalculateOrderPrice()
        {
            var price = orderBase.CalculateTotalOrderPrice();
            return price * 0.9;
        }
    }
}
