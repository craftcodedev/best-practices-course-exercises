using System.Collections.Generic;

namespace elearning.Shared.Domain
{
    public abstract class IntegerValueObject : ValueObject
    {
        public int Value { get; }

        public IntegerValueObject(int value)
        {
            Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}