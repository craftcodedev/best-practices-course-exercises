using ManageStore.Model.Customer;
using ManageStore.Model.Customer.ValueObject;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStore.Service.Logs;

namespace ManageStore.Tests.Services
{
    [TestFixture]
    class LoggingServiceTest
    {
        [Test]
        public void ItShoulReturnTrueWhenIsTryingToWriteFile()
        {
            //Arrange

            var loggingService = new LoggingService();

            CustomerId customerId = new CustomerId(1234);
            CustomerName customerName = new CustomerName("customer");
            Customer customer = Customer.Create(customerId, customerName);

            var items = new List<ILoggable>
            {
                customer
            };


            //Act
            var result = loggingService.WriteToFile(items, PathFile.PATH_FILE_FAKE);

            //Assert
            Assert.AreEqual(result, true);
        }
    }
}
