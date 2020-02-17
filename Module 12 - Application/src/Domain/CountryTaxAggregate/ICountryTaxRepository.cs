using App.Domain.CountryTaxAggregate;

namespace App.Domain.CountryTaxAggregate
{
    public interface ICountryTaxRepository
    {
        CountryTax FindByCode(CountryTaxCode code);
    }
}