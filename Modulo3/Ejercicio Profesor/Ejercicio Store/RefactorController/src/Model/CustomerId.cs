using RefactorController.src.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.Model
{
    public class CustomerId
    {
        private string value;

        public CustomerId(string value)
        {
            if(value == string.Empty)
            {
                InvalidCustomerEmpty.FromEmpty();
            }

            this.value = value;
        }

        public string Id()
        {
            return value;
        }
    }
}
