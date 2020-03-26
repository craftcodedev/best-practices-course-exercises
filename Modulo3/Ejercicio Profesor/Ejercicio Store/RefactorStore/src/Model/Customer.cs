using RefactorController.src.Service.Log;

namespace RefactorController.src.Model
{
    public class Customer : ILoggable
    {
        private CustomerId customerId;
        private CustomerName customerName;

        public Customer(CustomerId customerId, CustomerName customerName)
        {
            this.customerId = customerId;
            this.customerName = customerName;
        }

        public static Customer SignUp(CustomerId id, CustomerName name)
        {
            return new Customer(id, name);
        }

        public CustomerId Id()
        {
            return this.customerId;
        }

        public string Log()
        {
            return $"{Id().Id() } : {Name().Name() }";
        }

        public CustomerName Name()
        {
            return this.customerName;
        }
    }
}
