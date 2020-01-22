using ManageStore.Models;
using ManageStore.Models.ValueObjects;
using ManageStore.Repository;
using ManageStore.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.UseCase
{
    public class CreateCustomerUseCase
    {
        private ICustomerRepository customerRepository;
        private CustomerConverter converter;

        public CreateCustomerUseCase(ICustomerRepository customerRepository,
            CustomerConverter converter)
        {
            this.customerRepository = customerRepository;
            this.converter = converter;
        }

        public bool Execute(CreateCustomerRequest request)
        {
            CustomerId customerId = new CustomerId(request.id);
            CustomerName customerName = new CustomerName(request.name);

            Customer customer = Customer.SignUp(customerId, customerName);

            var dto = converter.Convert(customer);

            return customerRepository.Save(customer);
        }
    }
}
