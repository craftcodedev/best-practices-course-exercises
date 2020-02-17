using App.Shared.Domain.Exception;

namespace App.Domain.ProductAggregate.Service.Exception
{
    public class ProductNotFoundException : ResourceNotFoundException
    {
        public ProductNotFoundException(string message): base(message){}

        public static ProductNotFoundException FromId(ProductId id)
        {
            return new ProductNotFoundException(string.Format("product has not been found with the id {0}.", id.GetValue()));
        }
    }
}