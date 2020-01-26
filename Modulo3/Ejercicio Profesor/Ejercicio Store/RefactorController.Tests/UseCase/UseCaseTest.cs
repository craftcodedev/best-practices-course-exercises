using Moq;
using NUnit.Framework;
using RefactorController.src.Model;
using RefactorController.src.Repository;
using RefactorController.src.Service;
using RefactorController.src.UseCase;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorController.Tests.UseCase
{
    [TestFixture]
    class UseCaseTest
    {
        [Test]
        public void ItShouldReturnTrueIfUseCaseExecutedIsValid()
        {
            var mockRepository = new Mock<CustomerRepository>();
            var mockConverter = new Mock<CustomerConverter>();

            var createCustomerUseCase = new CreateCustomerUseCase(mockRepository.Object, mockConverter.Object);

            CustomerId id = new CustomerId("1111");
            CustomerName name = new CustomerName("customer");
            Customer customer = Customer.SignUp(id, name);

            CreateCustomerRequest request = new CreateCustomerRequest(id.Id(),name.Name());

            var actual = createCustomerUseCase.Execute(request);

            Assert.AreEqual("1111", actual.Id);
            Assert.AreEqual("customer", actual.Name);
        }
    }
}
