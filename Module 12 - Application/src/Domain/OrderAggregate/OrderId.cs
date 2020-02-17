using App.Shared.Domain;

namespace App.Domain.OrderAggregate
{
    public class OrderId : UUID
    {
        public OrderId(string value) : base(value) {}
    }
}