
using App.Domain.CustomerAggregate;
using App.Domain.CountryTaxAggregate;

namespace App.Domain.OrderAggregate.Service
{
    public class TaxCalculator
    {
        private ICustomerRepository customerRepository;
        private ICountryTaxRepository countryTaxRepository;

        public TaxCalculator(ICustomerRepository customerRepository, ICountryTaxRepository countryTaxRepository)
        {
            this.customerRepository = customerRepository;
            this.countryTaxRepository = countryTaxRepository;
        }

        public decimal Apply(decimal price, OrderCustomerId customerId)
        {
            Customer customer = this.customerRepository.FindOneById(new CustomerId(customerId.GetValue()));

            CountryTax countryTax = this.countryTaxRepository.FindByCode(new CountryTaxCode(customer.Country.GetValue()));
            
            return ((price * countryTax.Percentage().GetValue()) / 100) + price;
        }
    }
}