using App.Shared.Domain;
using App.Domain.CustomerAggregate.Exception;

namespace App.Domain.CustomerAggregate
{
    public class CustomerLastName : StringValueObject
    {
        public const int MAX_SIZE = 40;

        public CustomerLastName(string value) : base(value)
        {
            if (string.IsNullOrEmpty(value)) {
                throw InvalidCustomerAttributeException.FromEmpty("last name");
            }

            if (value.Length > CustomerFirstName.MAX_SIZE) {
                throw InvalidCustomerAttributeException.FromMaxLength("last name", CustomerFirstName.MAX_SIZE);
            }
        }
    }
}