using App.Shared.Domain;
using App.Domain.ProductAggregate.Exception;

namespace App.Domain.ProductAggregate
{
    public class ProductName : StringValueObject
    {
        public const int MAX_SIZE = 40;

        public ProductName(string value) : base(value)
        {
            if (string.IsNullOrEmpty(value)) {
                throw InvalidProductAttributeException.FromEmpty("name");
            }

            if (value.Length > ProductName.MAX_SIZE) {
                throw InvalidProductAttributeException.FromMaxLength("name", ProductName.MAX_SIZE);
            }
        }
    }
}