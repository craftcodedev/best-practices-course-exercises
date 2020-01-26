using NUnit.Framework;
using RefactorController.src.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace RefactorController.Tests.ValueObjects
{
    [TestFixture]
    public class VOTests
    {
        [Test]
        public void ItShoulReturnTrueIfTwoVOAreEqual()
        {
            CustomerId customerId1 = new CustomerId("1111");
            CustomerId customerId2 = new CustomerId("1111");

            Assert.AreEqual(customerId1, customerId2);
        }

        [Test]
        public void ItShoulReturnTrueIfVOHasSameValue()
        {
            CustomerId customerId = new CustomerId("1111");
            Assert.AreEqual("1111", customerId.Id());
        }
    }
}
