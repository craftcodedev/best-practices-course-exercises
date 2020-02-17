using App.Shared.Domain;
using App.Domain.CustomerAggregate.Exception;
using System.Collections.Generic;

namespace App.Domain.CustomerAggregate
{
    public class CustomerCountry : StringValueObject
    {
        private readonly List<string> countries = new List<string>(){"ar", "es", "de"};

        public CustomerCountry(string value) : base(value)
        {
            bool isNotValid = true;

            foreach (string country in this.countries) {
			
                if (country == value) {
                    isNotValid = false;
                }
            }

            if (isNotValid) {
                throw InvalidCustomerAttributeException.FromValue("country", value);
            }
        }
    }
}