using ManageStore.Model.Customer.ValueObject;
using ManageStore.Service.Logs;

namespace ManageStore.Model.Customer
{
    public class Customer : ILoggable
    {
        private CustomerId id;
        private CustomerName name;

        private Customer(CustomerId id, CustomerName name)
        {
            this.id = id;
            this.name = name;
        }

        public static Customer Create(CustomerId id, CustomerName name)
        {
            return new Customer(id, name);
        }

        public CustomerId Id()
        {
            return this.id;
        }

        public CustomerName Name()
        {
            return this.name;
        }

        public string Log(string value) => $"{id.CustomerID}: {name.CustomerNAME}";
    }
}
