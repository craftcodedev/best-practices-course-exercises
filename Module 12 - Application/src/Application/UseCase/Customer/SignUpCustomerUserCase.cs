using App.Domain.CustomerAggregate;
using App.Domain.CustomerAggregate.Service;
using App.Infrastructure.Service.Hashing;
using App.Shared.Domain.Bus.UseCase;
using App.Shared.Domain.Bus.Event;

namespace App.Application.UseCase
{
    public class SignUpCustomerUseCase : IUseCase
    {
        private ICustomerFactory customerFactory;
        private SignUpCustomerValidator signUpCustomerValidator;
        private ICustomerRepository customerRepository;
        private CustomerConverter customerConverter;
        private EventProvider eventProvider;

        public SignUpCustomerUseCase(
            ICustomerFactory customerFactory,
            SignUpCustomerValidator signUpCustomerValidator,
            ICustomerRepository customerRepository,
            CustomerConverter customerConverter,
            EventProvider eventProvider
        ) {
            this.customerFactory = customerFactory;
            this.signUpCustomerValidator = signUpCustomerValidator;
            this.customerRepository = customerRepository;
            this.customerConverter = customerConverter;
            this.eventProvider = eventProvider;
        }
        public IResponse Execute(IRequest req)
        {
            SignUpCustomerRequest request = req as SignUpCustomerRequest;
            Customer customer = this.customerFactory.Create(
                request.Id,
                request.Email,
                request.Password,
                request.FirstName,
                request.LastName,
                request.Country
            );

            CustomerRepeatPassword.Validate(request.RepeatPassword, request.Password);
            this.signUpCustomerValidator.Validate(customer.Email);

            //this.customerRepository.Save(customer);
            
            this.eventProvider.RecordEvents(customer.ReleaseEvents());

            return this.customerConverter.Convert(customer);
        }
    }
}