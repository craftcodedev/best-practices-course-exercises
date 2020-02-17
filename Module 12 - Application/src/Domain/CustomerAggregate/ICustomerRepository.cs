using App.Domain.CustomerAggregate;

namespace App.Domain.CustomerAggregate
{
    public interface ICustomerRepository
    {
        Customer FindOneById(CustomerId id);
        Customer FindOneByEmail(CustomerEmail email);
        void Save(Customer customer);
    }
}
