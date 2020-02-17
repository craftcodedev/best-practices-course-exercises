using System;
using System.Text;
using System.Security.Cryptography;
using App.Domain.ProductAggregate;

namespace App.Infrastructure.Service.CartService
{
    public class ProductFacade
    {
        IProductRepository productRepository;

        public ProductFacade(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public Product FindOneById(string productId)
        {
            return this.productRepository.FindOneById(new ProductId(productId));
        }
    }
}