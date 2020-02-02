using Decorator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class OrderDecorator
    {
        protected OrderBase orderBase;

        public OrderDecorator(OrderBase orderBase)
        {
            this.orderBase = orderBase;
        }

        public abstract double CalculateOrderPrice();
    }
}
