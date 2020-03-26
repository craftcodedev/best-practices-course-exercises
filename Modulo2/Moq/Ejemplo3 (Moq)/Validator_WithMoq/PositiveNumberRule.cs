using System;

namespace ValidatorWithMoq
{
    public class PositiveNumberRule : IValidatorRule
    {
        public bool IsValid(object obj)
        {
            if (long.TryParse(obj?.ToString(), out var l))
            {
                return l >= 0;
            }

            if (double.TryParse(obj?.ToString(), out var d))
            {
                return d >= 0;
            }

            return false;
        }
    }
}
