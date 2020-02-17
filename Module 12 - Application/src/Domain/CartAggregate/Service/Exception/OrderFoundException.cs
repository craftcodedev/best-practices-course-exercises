using App.Shared.Domain.Exception;

namespace App.Domain.CartAggregate.Service.Exception
{
    public class OrderFoundException : ValidationException
    {
        public OrderFoundException(string message): base(message){}

        public static OrderFoundException FromCustomerAndStatus()
        {
            return new OrderFoundException("you can have only one order open.");
        }
    }
}