using RefactorController.src.Model;
using RefactorController.src.Repository;
using RefactorController.src.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactorController.src.UseCase
{
    public class CreateCustomerUseCase
    {
        private CustomerRepository _customerRepository;
        private CustomerConverter _customerConverter;

        public CreateCustomerUseCase(CustomerRepository customerRepository, CustomerConverter customerConverter)
        {
            _customerRepository = customerRepository;
            _customerConverter = customerConverter;
        }

        public CustomerDTO Execute(CreateCustomerRequest request)
        {
            CustomerId id = new CustomerId(request.Id);
            CustomerName name = new CustomerName(request.Name);
            Customer customer = Customer.SignUp(id, name);
            _customerRepository.Save(customer);
            return _customerConverter.Convert(customer);
        }
    }
}
