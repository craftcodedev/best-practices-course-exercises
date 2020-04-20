using NUnit.Framework;
using Refactoring.Code_Smells;
using System;
using TecnicasRefactoring.Code_Smells.WithCodeSmells;

namespace Refactoring.Test.Code_Smells
{
    [TestFixture]
    public class CodeSmellProblemTest
    {
        [TestCaseSource(nameof(paramsData))]
        public void ItShouldReturnExceptionIfAnyParamIsInvalid(string productNumber, string customerId,
            int customerFiedLength, int productFieldLength, string exception)
        {
            //Arrange
            CustomerProduct customerProduct = new CustomerProduct
            {
                ProductNumber = productNumber
            };

            Customer customer = new Customer
            {
                CustomerID = customerId
            };

            CustomerRequest request = new CustomerRequest
            {
                CustomerProduct = customerProduct,
                Customer = customer,
                customerIDFieldLength = customerFiedLength,
                productFieldLength = productFieldLength
            };

            WithCodeSmells wcs = new WithCodeSmells();

            //Assert
            Exception ex = Assert.Throws<Exception>(() => wcs.ValidateRequest(request));
            Assert.That(ex.Message, Is.EqualTo(exception));
        }

        private static object[] paramsData =
        {
            new object[] { "10", "20", 10, 5, HandledErrors.InvalidBothParameterMessage },
            new object[] { "", "", 10, 5, HandledErrors.CustomerEmptyMessage },
            new object[] { "", "1234", 2, 5, HandledErrors.CustomerInvalidLengthMessage },
            new object[] { "1234", "", 2, 2, HandledErrors.ProductInvalidLengthMessage },
        };        

        [TestCase("", "1234", 8, 4, "00001234", "0000")]
        [TestCase("1111", "", 4, 8, "0000", "00001111")]
        public void ItShouldReturnPadLeftParamIfIsValid(string productNumber, string customerId,
            int customerFieldLength, int productFieldLength, string expectedCustomer, string expectedProduct)
        {
            //Arrange
            CustomerProduct customerProduct = new CustomerProduct
            {
                ProductNumber = productNumber
            };

            Customer customer = new Customer
            {
                CustomerID = customerId
            };

            CustomerRequest request = new CustomerRequest
            {
                CustomerProduct = customerProduct,
                Customer = customer,
                customerIDFieldLength = customerFieldLength,
                productFieldLength = productFieldLength
            };

            WithCodeSmells wcs = new WithCodeSmells();

            //Act
            wcs.ValidateRequest(request);

            //Assert            
            Assert.AreEqual(expectedCustomer, request.Customer.CustomerID);
            Assert.AreEqual(expectedProduct, request.CustomerProduct.ProductNumber);
        }        
    }
}
