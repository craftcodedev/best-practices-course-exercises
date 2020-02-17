using App.Domain.OrderAggregate;
using App.Domain.OrderAggregate.Service;


namespace App.Application.UseCase
{
    public class PayOrderUserCase
    {
        private OrderFinder orderFinder;
        private TaxCalculator taxCalculator;
        private IPaymentGateway paymentGateway;

        public PayOrderUserCase(
            OrderFinder orderFinder,
            TaxCalculator taxCalculator,
            IPaymentGateway paymentGateway
        ) {
            this.orderFinder = orderFinder;
            this.paymentGateway = paymentGateway;
        }
        
        public void Execute(PayOrderRequest request)
        {
            Order order = this.orderFinder.FindOneById(request.Id);

            decimal price = this.taxCalculator.Apply(order.GetTotalPrice(), order.CustomerId);
            
            this.paymentGateway.Pay(price, request.Method, request.MethodData);
            
            order.Finish();
            
            //this.eventProvider.recordEvents(order.ReleaseEvents());
        }
    }
}