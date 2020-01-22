using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStore.Model.Customer;
using ManageStore.Model.Customer.ValueObject;
using ManageStore.Repository;
using ManageStore.Service.Logs;
using NUnit.Framework;

namespace ManageStore.Tests
{
    [TestFixture]
    class FakeTest
    {
        [Test]
        public void ItShouldReturnsCustomerWhenFindByIdisExecuted()
        {
            //Arrange
            var fakeLoggingService = new FakeLoggingService();
            var customerRepository = new CustomerRepository(fakeLoggingService);

            CustomerId customerId = new CustomerId(1234);
            CustomerName customerName = new CustomerName("customer");
            Customer customer = Customer.Create(customerId, customerName);

            //Act
            var actual = customerRepository.FindById(customerId);

            //Assert
            Assert.IsNotNull(actual);
            Assert.AreEqual(customer.Id(), actual.Id());
            Assert.AreEqual(customer.Name(), actual.Name());
        }
    }

    public class FakeLoggingService : LoggingService
    {
        public bool ReadFileFake(string customerId, string path)
        {
            return ReadFile(customerId, path);
        }

        public bool WriteToFileFake(List<ILoggable> itemsToLog, string path)
        {
            return WriteToFile(itemsToLog, path);
        }
    }
}
