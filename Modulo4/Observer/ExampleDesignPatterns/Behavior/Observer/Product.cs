using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class Product : IProduct
    {
        string name;
        float basePrice;
        float currentPrice;
        List<Customer> customers = new List<Customer>();

        public Product(string name, float basePrice)
        {
            this.name = name;
            this.basePrice = basePrice;
            this.currentPrice = basePrice;
        }

        public float Price
        {
            get
            {
                return currentPrice;
            }
            set
            {
                currentPrice = value;

                if(value >= basePrice)
                {
                    Notify();
                }
            }
        }

        public string Name
        {
            get { return name; }
        }

        public float discount
        {
            get { return (basePrice - currentPrice) * 100 / basePrice; }
        }

        public float CurrentPrice
        {
            get { return currentPrice; }
        }

        public void Notify()
        {
            foreach (var customer in customers)
            {
                customer.Update(this);
            }
        }

        public void Subscribe(Customer customer)
        {
            customers.Add(customer);
        }

        public void Unsubscribe(Customer customer)
        {
            customers.Remove(customer);
        }
    }
}
