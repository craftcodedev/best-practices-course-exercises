using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Models.ValueObjects
{
    public class CustomerName
    {
        private string value;
        private const int MAX_LENGHT = 15;

        public CustomerName(string value)
        {
            if(value == string.Empty)
            {
                InvalidCustomerNameException.FromEmpty();             
            }

            if(value.Length > MAX_LENGHT)
            {
                InvalidCustomerNameException.FromMaxLenght();
            }

            this.value = value;
        }

        public string Name()
        {
            return value;
        }
    }
}
