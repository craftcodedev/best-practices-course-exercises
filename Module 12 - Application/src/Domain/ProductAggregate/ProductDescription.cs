using App.Shared.Domain;
using App.Domain.ProductAggregate.Exception;

namespace App.Domain.ProductAggregate
{
    public class ProductDescription : StringValueObject
    {
        public const int MAX_SIZE = 1300;

        public ProductDescription(string value) : base(value)
        {
            if (string.IsNullOrEmpty(value)) {
                throw InvalidProductAttributeException.FromEmpty("description");
            }

            if (value.Length > ProductDescription.MAX_SIZE) {
                throw InvalidProductAttributeException.FromMaxLength("description", ProductDescription.MAX_SIZE);
            }
        }
    }
}