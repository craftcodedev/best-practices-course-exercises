using App.Shared.Domain;

namespace App.Domain.CountryTaxAggregate
{
    public class CountryTaxPercentage : IntegerValueObject
    {
        private int value;

        public CountryTaxPercentage(int value) : base(value)
        {
        }
    }
}