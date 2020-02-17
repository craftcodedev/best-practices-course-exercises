using App.Domain.CartAggregate;

namespace App.Domain.CartAggregate
{
    public interface ICartService
    {
        CartProduct FindOneProductByIdProduct(string productId);
    }
}
