namespace App.Domain.OrderAggregate
{
    public interface IOrderFactory
    {
        Order Create(string id, string items, string customerId);
    }
}