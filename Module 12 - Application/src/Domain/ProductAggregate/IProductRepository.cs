using App.Domain.ProductAggregate;

namespace App.Domain.ProductAggregate
{
    public interface IProductRepository
    {
        Product FindOneById(ProductId id);
        Product FindOneByName(ProductName name);
        
        void Save(Product product);
    }
}
