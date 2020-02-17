using App.Shared.Domain;
using App.Domain.CustomerAggregate.Exception;

namespace App.Domain.CustomerAggregate
{
    public class CustomerEmail : StringValueObject
    {
        public CustomerEmail(string value) : base(value)
        {
            try {
                new System.Net.Mail.MailAddress(value);
            }
            catch {
                throw InvalidCustomerAttributeException.FromValue("email", value);
            }
        }
    }
}