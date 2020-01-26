using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring.Code_Smells
{
    public class CustomerRequest
    {
        public CustomerProduct CustomerProduct { get; set; }
        public Customer Customer { get; set; }
        public int customerIDFieldLength { get; set; }
        public int productFieldLength { get; set; }
    }
}
