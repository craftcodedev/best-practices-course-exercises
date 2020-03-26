using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Models
{
    public class InvalidCustomerIdException : Exception
    {
        public InvalidCustomerIdException(string message): base(message)
        {

        }

        public static InvalidCustomerIdException FromEmpty()
        {
            throw new InvalidCustomerIdException("CustomerId is not valid");
        }
    }
}
