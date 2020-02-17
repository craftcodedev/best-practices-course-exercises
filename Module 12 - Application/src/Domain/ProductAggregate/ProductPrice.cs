using App.Shared.Domain;
using App.Domain.ProductAggregate.Exception;

namespace App.Domain.ProductAggregate
{
    public class ProductPrice : DecimalValueObject
    {
        public ProductPrice(decimal value) : base(value)
        {
            if (value.Equals(0)) {
                throw InvalidProductAttributeException.FromEmpty("price");
            }
        }
    }
}