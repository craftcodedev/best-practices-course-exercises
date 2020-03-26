using System;

namespace ValidatorWithMoq
{
    public class RequiredRule : IValidatorRule
    {
        public bool IsValid(object obj)
        {
            if (obj is string s)
            {
                return !string.IsNullOrEmpty(s);
            }

            return obj != null;
        }
    }
}
