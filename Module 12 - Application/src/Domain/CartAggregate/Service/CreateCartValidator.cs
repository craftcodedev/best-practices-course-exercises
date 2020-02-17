using App.Domain.CartAggregate.Service.Exception;

namespace App.Domain.CartAggregate.Service
{
    public class CreateCartValidator
    {
        private ICartRepository cartRepository;

        public CreateCartValidator(ICartRepository cartRepository)
        {
            this.cartRepository = cartRepository;
        }
        
        public void Validate(CartCustomerId customerId)
        {
            this.CustomerCannotHaveMoreThanOneCartOpen(customerId);
        }

        private void CustomerCannotHaveMoreThanOneCartOpen(CartCustomerId customerId)
        {
            CartStatus status = new CartStatus(CartStatus.OPEN_STATUS);
            Cart cart = this.cartRepository.FindOneByCustomerIdAndStatus(customerId, status);

            if (cart is Cart) {
                throw CartFoundException.FromCustomerAndStatus();
            }
        }
    }
}