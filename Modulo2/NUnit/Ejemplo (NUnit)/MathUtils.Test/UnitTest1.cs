using MathTestWithNUnit;
using NUnit.Framework;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [TestCase(0,0)]
        [TestCase(1, 1)]
        [TestCase(3, 2)]
        [TestCase(6, 8)]
        public void CalculateFobonacciNumerShouldReturnsCorrectValue(int numberIndex, int expected)
        {
            //Arrange

            //Act
            var actual = MathUtils.CalculateFibonacciNumber(numberIndex);

            //Assert
            Assert.That(actual, Is.EqualTo(expected));

        }

        [Test]
        public void CalculateFibonacciNumberShouldReturnsExceptionByNegativeNumber()
        {
            //Arrange
            int numberIndex = -1;

            //Act
            TestDelegate actual = () => MathUtils.CalculateFibonacciNumber(numberIndex);

            //Assert
            Assert.That(actual, Throws.ArgumentException);
        }

        [TestCaseSource(nameof(getSequenceData))]
        public void GetFibonacciSequenceShouldReturnsCorrectSequence(int numberIndex, List<int> expected)
        {
            //Arrange
 

            //Act
            var actual = MathUtils.GetFibonacciSequence(numberIndex);

            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }

        private static object[] getSequenceData =
        {
            new object[] {0, new List<int>{0}},
            new object[] {1, new List<int>{0, 1}},
            new object[] {2, new List<int>{0,1,1}},
            new object[] {3, new List<int>{0,1,1,2}},
        };
    }
}