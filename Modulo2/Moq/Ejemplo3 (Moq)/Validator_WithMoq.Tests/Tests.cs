using Moq;
using NUnit.Framework;
using System;
using ValidatorWithMoq;

namespace Validator_WithMoq.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void IsValidShouldReturnsTrueIfThereAreNoRules()
        {
            var myField = -1;
            var v = new ValidatorRules();

            var actual = v.IsValid(nameof(myField), myField);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void IsValidShouldReturnsTrueIfRuleIsValid()
        {
            var myField = -1;
            var v = new ValidatorRules();

            var rule = new Mock<IValidatorRule>();

            rule.Setup(s => s.IsValid(myField)).Returns(true);

            v.AddRule(nameof(myField), rule.Object);

            var actual = v.IsValid(nameof(myField), myField);

            Assert.That(actual, Is.True);
        }

        [Test]
        public void AddRuleIncorrectShouldReturnException()
        {
            var myField = 400000000;
            var v = new ValidatorRules();

            var rule = new Mock<IValidatorRule>();

            rule.Setup(s => s.IsValid(myField)).Throws<StackOverflowException>();

            v.AddRule(nameof(myField), rule.Object);

            void del() => v.IsValid(nameof(myField), myField);

            Assert.Throws<StackOverflowException>(del);
        }

        [Test]
        public void IsValidShouldReturnsRuleOneTime()
        {
            var myField = -1;
            var v = new ValidatorRules();

            var rule = new Mock<IValidatorRule>();

            v.AddRule(nameof(myField), rule.Object);

            v.IsValid(nameof(myField), myField);

            rule.Verify(s => s.IsValid(It.IsAny<object>()), Times.Once);
        }
    }
}
