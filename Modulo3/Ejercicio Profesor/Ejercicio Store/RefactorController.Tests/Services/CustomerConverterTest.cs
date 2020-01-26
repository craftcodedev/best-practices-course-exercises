using NUnit.Framework;
using RefactorController.src.Model;
using RefactorController.src.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorController.Tests.Services
{
    [TestFixture]
    class CustomerConverterTest
    {
        [Test]
        public void ItShouldReturnDTOFromCustomer()
        {
            CustomerId id = new CustomerId("1111");
            CustomerName name = new CustomerName("customer");
            Customer customer = Customer.SignUp(id, name);

            CustomerConverter converter = new CustomerConverter();
            var actual = converter.Convert(customer);

            Assert.AreEqual("1111", actual.Id);
            Assert.AreEqual("customer", actual.Name);
        }
    }
}
