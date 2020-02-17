using App.Shared.Domain;
using System;

namespace App.Domain.CountryTaxAggregate
{
    public class CountryTax : AggregateRoot
    {
        private CountryTaxCode code;
        private CountryTaxPercentage percentage;

        private CountryTax(CountryTaxCode code, CountryTaxPercentage percentage)
        {
            this.code = code;
            this.percentage = percentage;
        }

        public static CountryTax Create(CountryTaxCode code, CountryTaxPercentage percentage)
        {
            CountryTax countryTax = new CountryTax(code, percentage);

            return countryTax;
        }

        public CountryTaxPercentage Percentage()
        {
            return this.percentage;
        } 
    }
}