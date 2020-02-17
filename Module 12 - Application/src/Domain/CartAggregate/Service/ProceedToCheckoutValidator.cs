using App.Domain.CartAggregate.Service.Exception;
using App.Domain.OrderAggregate;

namespace App.Domain.CartAggregate.Service
{
    public class ProceedToCheckoutValidator
    {
        private IOrderRepository orderRepository;

        public ProceedToCheckoutValidator(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        
        public void Validate(CartCustomerId customerId)
        {
            this.CustomerCannotHaveOneOrderOpen(customerId);
        }

        private void CustomerCannotHaveOneOrderOpen(CartCustomerId customerId)
        {
            OrderCustomerId orderCustomerId = new OrderCustomerId(customerId.GetValue());
            OrderStatus status = new OrderStatus(OrderStatus.INPROGRESS_STATUS);
            Order order = this.orderRepository.FindOneByCustomerIdAndStatus(orderCustomerId, status);

            if (order is Order) {
                throw OrderFoundException.FromCustomerAndStatus();
            }
        }
    }
}