using App.Shared.Domain;
using App.Domain.CustomerAggregate.Exception;
using System.Text.RegularExpressions;

namespace App.Domain.CustomerAggregate
{
    public class CustomerPassword : StringValueObject
    {
        private const string PATTERN = @"^([a-zA-Z0-9]{8,20})$";


        public CustomerPassword(string value) : base(value)
        {
            if (!this.Is(value)) {
                throw InvalidCustomerAttributeException.FromValue("password", value);
            }
        }

        private bool Is(string value)
        {
            Regex regex = new Regex(CustomerPassword.PATTERN);
            Match match = regex.Match(value);
            
            if (match.Success) {
                return true;
            }

            return false;
        }
    }
}