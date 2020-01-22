using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStore.Model.Customer;
using ManageStore.Model.Customer.ValueObject;
using ManageStore.Repository;
using ManageStore.Service.Logs;
using Moq;
using NUnit.Framework;

namespace ManageStore.Tests.TestDoubles
{
    [TestFixture]
    class StubTest
    {
        [Test]
        public void ItShouldReturnCustomerSaved()
        {
            //Arrange
            var mockLogService = new Mock<ILoggingService>();
            var customerRepository = new CustomerRepository(mockLogService.Object);

            CustomerId customerId = new CustomerId(1234);
            CustomerName customerName = new CustomerName("customer");
            Customer customer = Customer.Create(customerId, customerName);

            var changedItems = new List<ILoggable>
            {
                customer
            };

            mockLogService.Setup(m => m.WriteToFile(changedItems, PathFile.PATH_FILE_FAKE)).Returns(true);

            //Act
            var actual = customerRepository.Save(customer);

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(true, actual);
        }
    }
}
