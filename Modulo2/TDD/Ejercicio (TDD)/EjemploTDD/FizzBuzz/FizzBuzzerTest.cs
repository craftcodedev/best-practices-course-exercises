using NUnit.Framework;
using System;

namespace FizzBuzz
{
    [TestFixture]
    public class FizzBuzzerTest
    {
        [Test]
        public void Given15ExpectFizzBuzz()
        {
            var expected = "FizzBuzz";
            var actual = FizzBuzz(15);
            Assert.AreEqual(expected, actual);
        }

        private object FizzBuzz(int p)
        {
            if (p < 1)
                throw new IndexOutOfRangeException();
            if (p % 15 == 0)
                return "FizzBuzz";
            if (p % 3 == 0)
                return "Fizz";
            if (p % 5 == 0)
                return "Buzz";

            return p;
        }

        [Test]
        public void Given0ExpectException()
        {
            Assert.Throws<IndexOutOfRangeException>(() => FizzBuzz(0));
        }
    }
}