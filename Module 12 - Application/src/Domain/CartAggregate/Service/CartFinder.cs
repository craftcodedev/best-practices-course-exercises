using App.Domain.CartAggregate.Service.Exception;
using App.Domain.CartAggregate;  

namespace App.Domain.CartAggregate.Service
{
    public class CartFinder
    {
        private ICartRepository cartRepository;

        public CartFinder(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }
        
        public Cart FindOneById(string id)
        {
            CartId cartId = new CartId(id);
            Cart cart = this.cartRepository.FindOneById(cartId);

            if (!(cart is Cart)) {
                throw CartNotFoundException.FromId(cartId);
            }

            return cart;
        }
        
        public Cart FindOneByIdAndCustomerIdAndOpenStatus(string id, string customerId)
        {
            CartId cartId = new CartId(id);
            CartCustomerId cartCustomer = new CartCustomerId(customerId);
            CartStatus cartStatus = new CartStatus(CartStatus.OPEN_STATUS);
            Cart cart = this.cartRepository.FindOneByIdAndCustomerIdAndStatus(cartId, cartCustomer, cartStatus);

            if (!(cart is Cart)) {
                throw CartNotFoundException.FromId(cartId);
            }

            return cart;
        }
    }
}