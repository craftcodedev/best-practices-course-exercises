using App.Domain.CustomerAggregate.Service.Exception;

namespace App.Domain.CustomerAggregate.Service
{
    public class SignUpCustomerValidator
    {
        private ICustomerRepository customerRepository;

        public SignUpCustomerValidator(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        
        public void Validate(CustomerEmail email)
        {
            Customer customer = this.customerRepository.FindOneByEmail(email);

            if (customer is Customer) {
                throw CustomerFoundException.FromEmail(email);
            }
        }
    }
}