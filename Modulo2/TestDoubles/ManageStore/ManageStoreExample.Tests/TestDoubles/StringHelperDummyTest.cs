using ManageStore.Service.Logs;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageStore.Tests.TestDoubles
{
    [TestFixture]
    class StringHelperDummyTest
    {
        [Test]
        public void TestDoubleDummyExample()
        {
            string input = "aa";
            string expected = "AA";

            var mockLogger = new Mock<ILoggable>();
            StringHelper stringHelper = new StringHelper(mockLogger.Object);
            Assert.AreEqual(expected, stringHelper.ToUpper(input));
        }
    }
}
