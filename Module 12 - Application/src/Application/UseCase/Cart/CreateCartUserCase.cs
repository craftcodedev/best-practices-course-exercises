using App.Domain.CartAggregate;
using App.Domain.CartAggregate.Service;
using App.Infrastructure.Service.CartService;

namespace App.Application.UseCase
{
    public class CreateCartUserCase
    {
        private ICartFactory cartFactory;
        private CreateCartValidator createCartValidator;
        private ICartRepository cartRepository;

        public CreateCartUserCase(
            ICartFactory cartFactory,
            CreateCartValidator createCartValidator,
            ICartRepository cartRepository
        ) {
            this.cartFactory = cartFactory;
            this.createCartValidator = createCartValidator;
            this.cartRepository = cartRepository;
        }
        public string Execute(CreateCartRequest request)
        {
            Cart cart = this.cartFactory.Create(request.Id, request.CustomerId, request.ProductId);
            this.createCartValidator.Validate(cart.CustomerId);
            //converter

            this.cartRepository.Save(cart);

            return "";

            //this.eventProvider.recordEvents(cart.ReleaseEvents());
        }
    }
}