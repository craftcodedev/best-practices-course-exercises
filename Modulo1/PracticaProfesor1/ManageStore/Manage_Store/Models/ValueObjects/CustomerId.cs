using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Models.ValueObjects
{
    public class CustomerId
    {
        private string value;

        public CustomerId(string value)
        {
            if(value == string.Empty)
            {
                InvalidCustomerIdException.FromEmpty();
            }

            this.value = value;
        }

        public string Id()
        {
            return value;
        }
    }
}
