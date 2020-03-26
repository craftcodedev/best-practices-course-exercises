using ManageStore.Models.ValueObjects;
using ManageStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Models
{
    public class Customer : ILoggable
    {
        private CustomerId customerId;
        private CustomerName customerName;

        private Customer(CustomerId customerId, CustomerName customerName)
        {
            this.customerId = customerId;
            this.customerName = customerName;
        }

        public static Customer SignUp(CustomerId customerId, CustomerName customerName)
        {
            return new Customer(customerId, customerName);
        }

        public CustomerId Id()
        {
            return customerId;
        }

        public string Log()
        {
            return $"{this.customerId.Id()} : {customerName.Name()}";
        }

        public CustomerName Name()
        {
            return customerName;
        }
    }
}
