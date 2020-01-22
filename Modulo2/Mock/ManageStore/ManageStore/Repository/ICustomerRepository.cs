using ManageStore.Model.Customer;
using ManageStore.Model.Customer.ValueObject;

namespace ManageStore.Repository
{
    public interface ICustomerRepository
    {
        Customer FindById(CustomerId id);
        bool Save(Customer Customer);
    }
}
