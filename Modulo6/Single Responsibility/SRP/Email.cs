using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class Email
    {
        private string value;

        public Email(string value)
        {
            if(value.Contains("@"))
            {
                throw new Exception("Inavlid email");
            }

            this.value = value;                
        }

        public string EmailParam()
        {
            return value;
        }
    }
}
