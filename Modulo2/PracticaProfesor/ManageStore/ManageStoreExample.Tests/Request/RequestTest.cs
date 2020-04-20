using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStore.UseCase;
using NUnit.Framework;

namespace ManageStore.Tests.Request
{
    [TestFixture]
    class RequestTest
    {
        [Test]
        public void ItShouldReturnSameNumberOfValuesWhenRequestIsCreated()
        {
            //Arrange
            CreateCustomerRequest request = new CreateCustomerRequest(1, "Name");

            //Act
            Type type = typeof(CreateCustomerRequest);
            int numberOfFields = type.GetProperties().Length;

            //Assert
            Assert.AreEqual(numberOfFields, 2);
            Assert.AreEqual(request.Id, 1);
            Assert.AreEqual(request.Name, "Name");
        }
    }
}
