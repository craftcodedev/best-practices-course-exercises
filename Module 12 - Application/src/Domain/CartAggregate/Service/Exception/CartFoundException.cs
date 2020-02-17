using App.Shared.Domain.Exception;

namespace App.Domain.CartAggregate.Service.Exception
{
    public class CartFoundException : ValidationException
    {
        public CartFoundException(string message): base(message){}

        public static CartFoundException FromCustomerAndStatus()
        {
            return new CartFoundException("you can have only one cart open.");
        }
    }
}