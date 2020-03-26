using RefactorController.src.Model.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.Model
{
    public class CustomerName
    {
        private string value;
        const int MAX_LENGTH = 15;

        public CustomerName(string value)
        {
            if (value == string.Empty)
            {
                InvalidCustomerEmpty.FromEmpty();
            }

            if (value.Length > MAX_LENGTH)
            {
                InvalidCustomerLength.FromLength();
            }

            this.value = value;
        }

        public string Name()
        {
            return value;
        }
    }
}
