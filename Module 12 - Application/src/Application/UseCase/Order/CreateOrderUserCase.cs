using App.Domain.OrderAggregate;

namespace App.Application.UseCase
{
    public class CreateOrderUserCase
    {
        private IOrderFactory orderFactory;
        private IOrderRepository orderRepository;

        public CreateOrderUserCase(
            IOrderFactory orderFactory,
            IOrderRepository orderRepository
        ) {
            this.orderFactory = orderFactory;
            this.orderRepository = orderRepository;
        }
        
        public void Execute(CreateOrderRequest request)
        {
            Order order = this.orderFactory.Create(request.Id, request.Items, request.CustomerId);

            this.orderRepository.Save(order);

            //this.eventProvider.recordEvents(order.ReleaseEvents());
        }
    }
}