using System;

namespace ValidatorWithMoq
{
    public interface IValidatorRule
    {
        bool IsValid(object obj);
    }
}
