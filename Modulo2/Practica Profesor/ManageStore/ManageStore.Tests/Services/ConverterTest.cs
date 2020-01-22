using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStore.Model.Customer;
using ManageStore.Model.Customer.ValueObject;
using ManageStore.Service.Convert;
using NUnit.Framework;

namespace ManageStore.Tests.Services
{
    [TestFixture]
    class ConverterTest
    {
        [Test]
        public void ItShoulReturnSameDTOWhenIsTryingToConvert()
        {
            //Arrange
            CustomerId customerId = new CustomerId(1234);
            CustomerName customerName = new CustomerName("customer");
            Customer customer = Customer.Create(customerId, customerName);

            CustomerConverter converter = new CustomerConverter();

            //Act
            var result = converter.Convert(customer);

            //Assert
            Assert.AreEqual(result.Id, customer.Id().CustomerID);
            Assert.AreEqual(result.Name, customer.Name().CustomerNAME);
        }
    }
}
