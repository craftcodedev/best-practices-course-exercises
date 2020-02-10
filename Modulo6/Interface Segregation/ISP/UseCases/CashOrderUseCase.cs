using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.UseCases
{
    public class CashOrderUseCase
    {
        private readonly IOrderProcess _orderProcess;

        public CashOrderUseCase(IOrderProcess orderProcess)
        {
            _orderProcess = orderProcess;
        }

        public void SetCashOrder()
        {
            _orderProcess.ProcessOrder("1");
            _orderProcess.ValidateShippingAddress("address");
        }
    }
}
