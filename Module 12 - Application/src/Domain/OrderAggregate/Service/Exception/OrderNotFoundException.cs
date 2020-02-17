using App.Shared.Domain.Exception;

namespace App.Domain.OrderAggregate.Service.Exception
{
    public class OrderNotFoundException : ResourceNotFoundException
    {
        public OrderNotFoundException(string message): base(message){}

        public static OrderNotFoundException FromId(OrderId id)
        {
            return new OrderNotFoundException(string.Format("order has not been found with the id {0}.", id.GetValue()));
        }
    }
}