using System;
using System.Collections.Generic;
using NUnit.Framework;
using RefactorController.src.Model;
using RefactorController.src.Service.Log;

namespace ManageStore.Tests.Services
{
    [TestFixture]
    public class LoggingServiceTest
    {
        [Test]
        public void ItShouldReturnTrueWhenItsTryingToWriteFile()
        {
            //Arrange
            LoggingService logging = new LoggingService();
            CustomerId id = new CustomerId("1111");
            CustomerName name = new CustomerName("customer");
            Customer customer = Customer.SignUp(id, name);

            var changedItems = new List<ILoggable>
            {
                customer
            };

            //Act
            var result = logging.WriteToFile(changedItems, "C:\\Users\\Usuario\\Documents");

            //Assert
            Assert.AreEqual(result, true);
        }
    }
}
