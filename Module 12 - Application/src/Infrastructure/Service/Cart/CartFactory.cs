using App.Domain.CartAggregate;

namespace App.Infrastructure.Service.CartService
{
    public class CartFactory : ICartFactory
    {
        private ICartService cartService;

        public CartFactory(ICartService cartService)
        {
            this.cartService = cartService;
        }

        public Cart Create(
            string id,
            string customerId,
            string productId
        ) {
            CartId cartId = new CartId(id);
            CartCustomerId cartCustomerId = new CartCustomerId(customerId);
            CartProduct cartProduct = this.cartService.FindOneProductByIdProduct(productId);

            return Cart.Create(cartId, cartCustomerId, cartProduct);
        }
    }
}