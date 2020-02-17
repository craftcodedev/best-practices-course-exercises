using App.Domain.CartAggregate;
using App.Domain.CartAggregate.Service;
using App.Infrastructure.Service.CartService;

namespace App.Application.UseCase
{
    public class RemoveProductFromCartUserCase
    {
        private CartFinder cartFinder;
        private ICartService cartService;

        public RemoveProductFromCartUserCase(
            CartFinder cartFinder,
            ICartService cartService
        ) {
            this.cartFinder = cartFinder;
            this.cartService = cartService;
        }
        
        public void Execute(AddProductToCartRequest request)
        {
            Cart cart = this.cartFinder.FindOneByIdAndCustomerIdAndOpenStatus(request.Id, request.CustomerId);
            CartProduct cartProduct = this.cartService.FindOneProductByIdProduct(request.ProductId);
            cart.Remove(cartProduct);
            //this.eventProvider.recordEvents(cart.ReleaseEvents());
        }
    }
}