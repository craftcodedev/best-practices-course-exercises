using App.Domain.OrderAggregate;

namespace App.Infrastructure.Service.OrderService
{
    public class OrderFactory : IOrderFactory
    {
        public Order Create(
            string id,
            string items,
            string customerId
        ) {
            OrderId orderId = new OrderId(id);
            OrderItems orderItems = new OrderItems();
            OrderCustomerId orderCustomerId = new OrderCustomerId(customerId);

            return Order.Create(orderId, orderItems, orderCustomerId);
        }
    }
}