using App.Shared.Domain.Exception;

namespace App.Domain.CustomerAggregate.Service.Exception
{
    public class CustomerFoundException : ValidationException
    {
        public CustomerFoundException(string message): base(message){}

        public static CustomerFoundException FromEmail(CustomerEmail email)
        {
            return new CustomerFoundException(string.Format("customer is already registered with the email {0}.", email.GetValue()));
        }
    }
}