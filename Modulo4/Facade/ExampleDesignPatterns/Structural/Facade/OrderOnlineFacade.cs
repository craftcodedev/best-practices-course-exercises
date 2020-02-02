using Facade.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class OrderOnlineFacade
    {
        private IInventory inventory;
        private ICosting costing;
        private ILogistics logistic;
        private IOrderVerify orderVerify;
        private IPaymentGateway payment;

        public OrderOnlineFacade(IInventory inventory, ICosting costing, ILogistics logistic,
            IOrderVerify orderVerify, IPaymentGateway payment)
        {
            this.inventory = inventory;
            this.costing = costing;
            this.logistic = logistic;
            this.orderVerify = orderVerify;
            this.payment = payment;
        }

        public void FinalizeOrder(OrderDetails details)
        {
            inventory.Update(details.ProductNo);
            costing.ApplyDiscounts(details.Price, details.DiscountPercent);
            logistic.ShipProduct(details.ProductName, details.AddressLine1);
            orderVerify.VerifyShippingAddress(details.PinCode);
            payment.ProcessPayment(details.CardNo, details.Price);
        }
    }
}
