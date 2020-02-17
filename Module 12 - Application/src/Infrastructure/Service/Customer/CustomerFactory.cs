using App.Domain.CustomerAggregate;
using App.Infrastructure.Service.Hashing;

namespace App.Infrastructure.Service.CustomerService
{
    public class CustomerFactory : ICustomerFactory
    {
        private IHashing hashing;

        public CustomerFactory(IHashing hashing)
        {
            this.hashing = hashing;
        }
        public Customer Create(
            string id,
            string email,
            string password,
            string firstName,
            string lastName,
            string country
        ) {

            password = this.hashing.Hash(password);
            CustomerId customerId = new CustomerId(id);
            CustomerEmail customerEmail = new CustomerEmail(email);
            CustomerHashedPassword customerPassword = new CustomerHashedPassword(password);
            CustomerFirstName customerFirstName = new CustomerFirstName(firstName);
            CustomerLastName customerLastName = new CustomerLastName(lastName);
            CustomerCountry customerCountry = new CustomerCountry(country);

            return Customer.SignUp(customerId, customerEmail, customerPassword, customerFirstName, customerLastName, customerCountry);
        }
    }
}