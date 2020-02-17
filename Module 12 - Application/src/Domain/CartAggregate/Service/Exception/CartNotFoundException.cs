using App.Shared.Domain.Exception;

namespace App.Domain.CartAggregate.Service.Exception
{
    public class CartNotFoundException : ResourceNotFoundException
    {
        public CartNotFoundException(string message): base(message){}

        public static CartNotFoundException FromId(CartId id)
        {
            return new CartNotFoundException(string.Format("cart has not been found with the id {0}.", id.GetValue()));
        }
    }
}