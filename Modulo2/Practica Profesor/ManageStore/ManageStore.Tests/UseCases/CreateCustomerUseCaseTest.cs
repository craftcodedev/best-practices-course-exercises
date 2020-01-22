using ManageStore.Model.Customer;
using ManageStore.Model.Customer.ValueObject;
using ManageStore.Service.Logs;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStore.Repository;
using ManageStore.UseCase;
using Moq;

namespace ManageStore.Tests.UseCases
{
    [TestFixture]
    class CreateCustomerUseCaseTest
    {
        [Test]
        public void ItShoulReturnTrueWhenCustomerIsTryingToSave()
        {
            //Arrange
            var mockRepository = new Mock<ICustomerRepository>();
            var customerUseCase = new CreateCustomerUseCase(mockRepository.Object);

            CustomerId customerId = new CustomerId(1234);
            CustomerName customerName = new CustomerName("customer");
            Customer customer = Customer.Create(customerId, customerName);

            mockRepository.Setup(s => s.Save(customer)).Returns(true);

            //Act
            CreateCustomerRequest request = new CreateCustomerRequest(1, "Name");
            var result = customerUseCase.Execute(request);

            //Assert
            Assert.AreEqual(result, true);
        }
    }
}
