using ManageStore.Repository;
using ManageStore.Model.Customer;
using ManageStore.Model.Customer.ValueObject;

namespace ManageStore.UseCase
{
    public class FindCustomerByIdUseCase
    {
        private ICustomerRepository CustomerRepository;

        public FindCustomerByIdUseCase(ICustomerRepository CustomerRepository)
        {
            this.CustomerRepository = CustomerRepository;
        }

        public Customer Execute(FindCustomerByIdRequest request)
        {
            CustomerId customerId = new CustomerId(request.Id);
            return this.CustomerRepository.FindById(customerId);
        }
    }
}
