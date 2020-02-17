using App.Domain.PaymentAggregate;

namespace App.Application.UseCase
{
    public class CreatePaymentUserCase
    {
        private IPaymentFactory paymentFactory;
        private IPaymentRepository paymentRepository;

        public CreatePaymentUserCase(
            IPaymentFactory paymentFactory,
            IPaymentRepository paymentRepository
        ) {
            this.paymentFactory = paymentFactory;
            this.paymentRepository = paymentRepository;
        }
        
        public void Execute(CreatePaymentRequest request)
        {
            Payment payment = this.paymentFactory.Create(request.Id, request.Price, request.Method, request.OrderId, request.CustomerId);

            this.paymentRepository.Save(payment);

            //this.eventProvider.recordEvents(payment.ReleaseEvents());
        }
    }
}