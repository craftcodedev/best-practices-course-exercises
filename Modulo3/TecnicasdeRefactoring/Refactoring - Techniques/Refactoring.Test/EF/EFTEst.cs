using NUnit.Framework;
using Refactoring.EncapsulateField;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Test.EF
{
    [TestFixture]
    class EFTest
    {
        [Test]
        public void ItShouldReturnAmountWnenGetIsExecuted()
        {
            //Arrange
            int units = 10;
            double price = 20;
            OrderEF order = new OrderEF(units, price);

            //Act
            var actual = order.getAmount();

            //Assert
            Assert.AreEqual(actual, Convert.ToDecimal(order.getUnits() * price));
        }
    }
}
