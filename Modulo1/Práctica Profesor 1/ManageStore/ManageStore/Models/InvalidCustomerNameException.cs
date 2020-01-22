using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Models
{
    public class InvalidCustomerNameException : Exception
    {
        public InvalidCustomerNameException(string message): base(message)
        {

        }

        public static InvalidCustomerNameException FromEmpty()
        {
            throw new InvalidCustomerNameException("CustomerName is not valid");
        }

        public static InvalidCustomerNameException FromMaxLenght()
        {
            throw new InvalidCustomerNameException("CustomerName lenght is not valid");
        }
    }
}
