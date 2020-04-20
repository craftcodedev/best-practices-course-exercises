using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.ValueObjects
{
    public class UserEmail
    {
        private string value;

        public UserEmail(string value)
        {
            if(!value.Contains("@"))
            {
                throw new Exception("Invalid email");
            }

            this.value = value;
        }

        public string Email()
        {
            return value;
        }
    }
}
