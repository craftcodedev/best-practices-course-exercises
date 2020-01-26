using Moq;
using NUnit.Framework;
using RefactorController.src.Model;
using RefactorController.src.Repository;
using RefactorController.src.Service;
using RefactorController.src.Service.Log;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorControllerTests.Repository
{
    [TestFixture]
    public class RepositoryTest
    {
        [Test]
        public void ItShouldReturnTrueWhenItsTryingToSaveCustomer()
        {
            //Arrange
            var mockLoggingService = new Mock<ILoggingService>();
            var customerRepository = new CustomerRepository(mockLoggingService.Object);

            CustomerId id = new CustomerId("1111");
            CustomerName name = new CustomerName("customer");
            Customer customer = Customer.SignUp(id, name);

            var changedItems = new List<ILoggable>
            {
                customer
            };

            mockLoggingService.Setup(s => s.WriteToFile(changedItems, PathFile.PATH_FILE)).Returns(true);

            var actual = customerRepository.Save(customer);

            Assert.AreEqual(true, actual);
        }
    }
}
