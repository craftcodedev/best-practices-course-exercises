using App.Shared.Domain;
using App.Domain.CustomerAggregate.Exception;

namespace App.Domain.CustomerAggregate
{
    public class CustomerFirstName : StringValueObject
    {
        public const int MAX_SIZE = 40;

        public CustomerFirstName(string value) : base(value)
        {
            if (string.IsNullOrEmpty(value)) {
                throw InvalidCustomerAttributeException.FromEmpty("first name");
            }

            if (value.Length > CustomerFirstName.MAX_SIZE) {
                throw InvalidCustomerAttributeException.FromMaxLength("first name", CustomerFirstName.MAX_SIZE);
            }
        }
    }
}