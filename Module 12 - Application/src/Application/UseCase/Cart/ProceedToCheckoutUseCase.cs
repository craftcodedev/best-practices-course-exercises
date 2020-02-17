using App.Domain.CartAggregate;
using App.Domain.CartAggregate.Service;
using App.Infrastructure.Service.CartService;
using App.Domain.CartAggregate.Service.Exception;

namespace App.Application.UseCase
{
    public class ProceedToCheckoutUserCase
    {
        private CartFinder cartFinder;
        private ProceedToCheckoutValidator proceedToCheckoutValidator;

        public ProceedToCheckoutUserCase(
            CartFinder cartFinder,
            ProceedToCheckoutValidator proceedToCheckoutValidator
        ) {
            this.cartFinder = cartFinder;
            this.proceedToCheckoutValidator = proceedToCheckoutValidator;
        }
        public void Execute(ProceedToCheckoutRequest request)
        {
            Cart cart = this.cartFinder.FindOneById(request.Id);
            this.proceedToCheckoutValidator.Validate(cart.CustomerId);
            cart.ProceedToCheckout(new CartStatus(request.Status));
            //this.eventProvider.recordEvents(cart.ReleaseEvents());
        }
    }
}