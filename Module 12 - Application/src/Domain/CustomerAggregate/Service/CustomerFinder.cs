using App.Domain.CustomerAggregate.Service.Exception;
using App.Domain.CustomerAggregate;  

namespace App.Domain.CustomerAggregate.Service
{
    public class CustomerFinder
    {
        private ICustomerRepository customerRepository;

        public CustomerFinder(ICustomerRepository customerRepository)
        {
            this.customerRepository = customerRepository;
        }
        
        public Customer FindOneById(CustomerId customerId)
        {
            Customer customer = this.customerRepository.FindOneById(customerId);

            if (!(customer is Customer)) {
                throw CustomerNotFoundException.FromId(customerId);
            }

            return customer;
        }
    }
}