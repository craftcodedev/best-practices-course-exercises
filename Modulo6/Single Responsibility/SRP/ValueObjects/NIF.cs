using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.ValueObjects
{
    public class UserNIF
    {
        private string value;

        public UserNIF(string value)
        {
            if (value.Length != 11)
            {
                throw new Exception("Invalid NIF");
            }

            this.value = value;
        }

        public string NIF()
        {
            return value;
        }
    }
}
