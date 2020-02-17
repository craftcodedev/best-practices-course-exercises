using App.Domain.CartAggregate;

namespace App.Domain.CartAggregate
{
    public interface ICartRepository
    {
        Cart FindOneById(CartId id);
        Cart FindOneByCustomerIdAndStatus(CartCustomerId customerId, CartStatus status);
        Cart FindOneByIdAndCustomerIdAndStatus(CartId id, CartCustomerId customerId, CartStatus status);
        void Save(Cart cart);
        void Update(Cart cart);
    }
}