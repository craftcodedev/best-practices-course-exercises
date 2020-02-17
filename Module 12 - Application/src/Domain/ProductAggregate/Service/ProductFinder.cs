using App.Domain.ProductAggregate.Service.Exception;
using App.Domain.ProductAggregate;  

namespace App.Domain.ProductAggregate.Service
{
    public class ProductFinder
    {
        private IProductRepository productRepository;

        public ProductFinder(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        
        public Product FindOneById(ProductId id)
        {
            Product product = this.productRepository.FindOneById(id);

            if (!(product is Product)) {
                throw ProductNotFoundException.FromId(id);
            }

            return product;
        }
    }
}