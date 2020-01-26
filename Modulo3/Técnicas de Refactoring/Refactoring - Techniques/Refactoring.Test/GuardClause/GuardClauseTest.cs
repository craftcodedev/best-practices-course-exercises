using NUnit.Framework;
using Refactoring.GuardClause;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refactoring.Test.GuardClause
{
    [TestFixture]
    class GuardClauseTest
    {
        [TestCase(null, "subscription", TermEnum.Annually, false)]
        [TestCase("user", null, TermEnum.Annually, false)]
        [TestCase("user", "subscription", TermEnum.Daily, false)]
        [TestCase("user", "subscription", TermEnum.Annually, true)]
        public void ItShouldReturnFalseWhenParamIsNull(string user, string subscription, TermEnum term, bool expected)
        {
            //Arrange
            var subscriptionParam = new SubscriptionParams
            {
                User = user,
                Subscription = subscription,
                Term = term
            };

            GuardClauseExample guard = new GuardClauseExample();
            var actual = guard.Subscribe(subscriptionParam);

            //Assert
            Assert.AreEqual(expected, actual);
        }     
    }
}
