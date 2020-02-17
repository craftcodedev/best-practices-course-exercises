using App.Shared.Domain;

namespace App.Domain.CountryTaxAggregate
{
    public class CountryTaxCode : StringValueObject
    {
        private string value;

        public CountryTaxCode(string value) : base(value)
        {
        }
    }
}