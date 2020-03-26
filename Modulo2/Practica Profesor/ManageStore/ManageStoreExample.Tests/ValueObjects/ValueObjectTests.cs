using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ManageStore.Model.Customer.ValueObject;
using NUnit.Framework;

namespace ManageStore.Tests.ValueObjects
{
    [TestFixture]
    class ValueObjectTests
    {
        [Test]
        public void CreateInvalidCustomerIdShouldReturnException()
        {
            CustomerId customerId;
            Assert.Throws<Exception>(() => customerId = new CustomerId(0));
        }

        [Test]
        public void ItShouldReturnTrueWhenTwoVOAreEqual()
        {
            CustomerId customerId1 = new CustomerId(1111);
            CustomerId customerId2 = new CustomerId(1111);

            Assert.AreEqual(customerId1, customerId2);
        }

        [Test]
        public void ItShouldReturnSameValueWhenVOIsCreated()
        {
            CustomerId customerId = new CustomerId(1111);
            Assert.AreEqual("1111", customerId.GetValue());
        }
    }
}
