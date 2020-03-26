using System;

namespace ManageStore.Model.Customer.ValueObject.Exception
{
    public class InvalidCustomerNameException : System.Exception
    {
        public InvalidCustomerNameException(string message): base(message){}

        public static void FromEmpty()
        {
            throw new InvalidCustomerNameException("Customer name is empty");
        }

        public static void FromMaxLength()
        {
            throw new InvalidCustomerNameException("Customer name cannot be longer than 15 characters");
        }
    }
}