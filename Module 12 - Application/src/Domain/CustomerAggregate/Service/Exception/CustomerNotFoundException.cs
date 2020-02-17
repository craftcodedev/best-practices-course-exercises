using App.Shared.Domain.Exception;

namespace App.Domain.CustomerAggregate.Service.Exception
{
    public class CustomerNotFoundException : ResourceNotFoundException
    {
        public CustomerNotFoundException(string message): base(message){}

        public static CustomerNotFoundException FromId(CustomerId id)
        {
            return new CustomerNotFoundException(string.Format("customer has not been found with the id {0}.", id.GetValue()));
        }
    }
}