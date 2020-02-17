namespace App.Domain.CartAggregate
{
    public interface ICartFactory
    {
        Cart Create(string id, string customerId, string productId);
    }
}