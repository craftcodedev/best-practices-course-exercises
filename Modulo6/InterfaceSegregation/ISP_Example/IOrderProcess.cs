using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IOrderProcess
    {
        bool ValidateShippingAddress(string address);
        void ProcessOrder(string order);
    }
}
