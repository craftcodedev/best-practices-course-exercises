using App.Domain.OrderAggregate.Service.Exception;
using App.Domain.OrderAggregate;  

namespace App.Domain.OrderAggregate.Service
{
    public class OrderFinder
    {
        private IOrderRepository orderRepository;

        public OrderFinder(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        
        public Order FindOneById(string id)
        {
            OrderId orderId = new OrderId(id);
            Order order = this.orderRepository.FindOneById(orderId);

            if (!(order is Order)) {
                throw OrderNotFoundException.FromId(orderId);
            }

            return order;
        }
    }
}