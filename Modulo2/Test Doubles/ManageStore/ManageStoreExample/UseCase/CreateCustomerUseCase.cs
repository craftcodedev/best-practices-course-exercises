using System;
using ManageStore.Repository;
using ManageStore.Repository.Exception;
using ManageStore.Model.Customer;
using ManageStore.Model.Customer.ValueObject;

namespace ManageStore.UseCase
{
    public class CreateCustomerUseCase
    {
        private ICustomerRepository CustomerRepository;

        public CreateCustomerUseCase(ICustomerRepository CustomerRepository)
        {
            this.CustomerRepository = CustomerRepository;
        }

        public bool Execute(CreateCustomerRequest request)
        {
            try
            {
                CustomerId CustomerId = new CustomerId(request.Id);
                CustomerName CustomerName = new CustomerName(request.Name);
                Customer customer = Customer.Create(CustomerId, CustomerName);

                Customer customerFound = this.CustomerRepository.FindById(CustomerId);

                if (customerFound != null)
                {
                    CustomerFoundException.FromId(customerFound.Id().CustomerID);
                }

                CustomerRepository.Save(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
