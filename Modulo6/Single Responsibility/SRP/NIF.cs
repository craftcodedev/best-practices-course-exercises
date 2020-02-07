using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{
    public class NIF
    {
        private string value;

        public NIF(string value)
        {
            if(value.Length != 10)
            {
                throw new Exception("Invalid NIF");
            }

            this.value = value;
        }

        public string NIFParam()
        {
            return value;
        }
    }
}
