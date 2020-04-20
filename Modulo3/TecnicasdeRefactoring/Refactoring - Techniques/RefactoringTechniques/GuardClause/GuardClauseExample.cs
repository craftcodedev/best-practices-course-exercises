namespace Refactoring.GuardClause
{
    public class GuardClauseExample
    {
        public bool Subscribe(SubscriptionParams subscriptionParams)
        {
            try
            {
                GuardChecking.AgainstNull(subscriptionParams.User, subscriptionParams.User);
                GuardChecking.AgainstNull(subscriptionParams.Subscription, subscriptionParams.Subscription);
                GuardChecking.AgainstInvalidTerm(subscriptionParams.Term, subscriptionParams.Term.ToString());

                SetSubscriptionMessage.SetMessage(subscriptionParams.Term);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

