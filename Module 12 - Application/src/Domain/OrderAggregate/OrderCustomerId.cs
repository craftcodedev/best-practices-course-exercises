using App.Shared.Domain;

namespace App.Domain.OrderAggregate
{
    public class OrderCustomerId : UUID
    {
        public OrderCustomerId(string value) : base(value) {}
    }
}