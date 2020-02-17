namespace App.Domain.CustomerAggregate
{
    public interface ICustomerFactory
    {
        Customer Create(
            string id,
            string email,
            string password,
            string firstName,
            string lastName,
            string country
        );
    }
}