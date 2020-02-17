using System;
using System.Text;
using System.Security.Cryptography;
using App.Domain.ProductAggregate;
using App.Domain.CartAggregate;

namespace App.Infrastructure.Service.CartService
{
    public class ProductTranslator
    {
        public CartProduct FromProductToCartProduct(Product product)
        {
            return new CartProduct(
                product.Id.GetValue(),
                product.Name.GetValue(),
                product.Price.GetValue()
            );
        }
    }
}
