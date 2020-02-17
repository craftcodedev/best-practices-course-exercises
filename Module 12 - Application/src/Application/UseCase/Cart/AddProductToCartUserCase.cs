using App.Domain.CartAggregate;
using App.Domain.CartAggregate.Service;
using App.Infrastructure.Service.CartService;

namespace App.Application.UseCase
{
    public class AddProductToCartUserCase
    {
        private CartFinder cartFinder;
        private ICartService cartService;
        private ICartRepository cartRepository;

        public AddProductToCartUserCase(
            CartFinder cartFinder,
            ICartService cartService,
            ICartRepository cartRepository
        ) {
            this.cartFinder = cartFinder;
            this.cartService = cartService;
            this.cartRepository = cartRepository;
        }
        public void Execute(AddProductToCartRequest request)
        {
            Cart cart = this.cartFinder.FindOneByIdAndCustomerIdAndOpenStatus(request.Id, request.CustomerId);
            CartProduct cartProduct = this.cartService.FindOneProductByIdProduct(request.ProductId);
            cart.Add(cartProduct);
            this.cartRepository.Update(cart);
            //this.eventProvider.recordEvents(cart.ReleaseEvents());
        }
    }
}