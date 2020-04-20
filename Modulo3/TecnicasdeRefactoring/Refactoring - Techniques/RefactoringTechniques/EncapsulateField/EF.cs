using System;

namespace Refactoring.EncapsulateField
{
    public class Order
    {
        private int units;
        private double price;

        public Order(int units, double price)
        {
            this.units = units;
            this.price = price;
        }

        public int getUnits()
        {
            return units;
        }

        public decimal getAmount()
        {
            return Convert.ToDecimal(units * price);
        }
    }

    public class OrderEF
    {
        private readonly int units;
        private readonly double price;

        public OrderEF(int units, double price)
        {
            this.units = units;
            this.price = price;
        }

        public int getUnits()
        {
            return units;
        }

        private double getPrice()
        {
            return price;
        }

        public decimal getAmount()
        {
            return Convert.ToDecimal(getUnits() * getPrice());
        }
    }
}
