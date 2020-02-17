using System;
using System.Text;
using System.Security.Cryptography;
using App.Domain.ProductAggregate;
using App.Domain.CartAggregate;

namespace App.Infrastructure.Service.CartService
{
    public class CartService : ICartService
    {
        private ProductFacade productFacade;
        private ProductTranslator productTranslator;

        public CartService(ProductFacade productFacade, ProductTranslator productTranslator)
        {
            this.productFacade = productFacade;
            this.productTranslator = productTranslator;
        }

        public CartProduct FindOneProductByIdProduct(string productId)
        {
            Product product = this.productFacade.FindOneById(productId);
            
            return this.productTranslator.FromProductToCartProduct(product);
        }
    }
}