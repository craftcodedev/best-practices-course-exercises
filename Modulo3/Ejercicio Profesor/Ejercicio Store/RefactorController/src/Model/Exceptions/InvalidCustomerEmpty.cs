using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.Model.Exceptions
{
    public class InvalidCustomerEmpty : Exception
    {
        public InvalidCustomerEmpty(string message) : base(message)
        {

        }

        public static InvalidCustomerEmpty FromEmpty()
        {
            return new InvalidCustomerEmpty("CustomerId is empty");
        }
    }
}
