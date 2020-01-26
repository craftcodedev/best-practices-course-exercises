using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.Model.Exceptions
{
    public class InvalidCustomerLength : Exception
    {
        public InvalidCustomerLength(string message) : base(message)
        {

        }

        public static InvalidCustomerLength FromLength()
        {
            return new InvalidCustomerLength("CustomerName has invalid length");
        }
    }
}
