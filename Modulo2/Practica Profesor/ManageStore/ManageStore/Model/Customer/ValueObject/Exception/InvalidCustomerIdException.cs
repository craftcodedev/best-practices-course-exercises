using System;

namespace ManageStore.Model.Customer.ValueObject.Exception
{
    public class InvalidCustomerIdException : System.Exception
    {
        public InvalidCustomerIdException(string message): base(message){}

        public static void FromZero()
        {
            throw new InvalidCustomerIdException("Customer id is not valid");
        }
    }
}