using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class CashOnDeliveryOrderProcess : IOrderProcess
    {
        public void ProcessOrder(string order)
        {
            // APPLICABLE
        }

        public bool ValidateShippingAddress(string address)
        {
            // APPLICABLE
            return true;
        }
    }
}
