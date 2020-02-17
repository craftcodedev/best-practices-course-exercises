using App.Domain.OrderAggregate;

namespace App.Domain.OrderAggregate
{
    public interface IOrderRepository
    {
        Order FindOneById(OrderId id);
        Order FindOneByCustomerIdAndStatus(OrderCustomerId customerId, OrderStatus status);
        void Save(Order order);
    }
}