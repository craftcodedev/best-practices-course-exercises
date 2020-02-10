using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP.UseCases
{
    public class OnlineOrderUseCase
    {
        private readonly IOrderProcess _orderProcess;
        private readonly IOnlineOrderProcess _orderOnlineProcess;

        public OnlineOrderUseCase(IOrderProcess orderProcess, IOnlineOrderProcess orderOnlineProcess)
        {
            _orderProcess = orderProcess;
            _orderOnlineProcess = orderOnlineProcess;
        }

        public void SetOnlineOrder()
        {
            _orderProcess.ProcessOrder("1");
            _orderProcess.ValidateShippingAddress("address");
            _orderOnlineProcess.ValidateCardInfo("carInfo");
        }
    }
}
