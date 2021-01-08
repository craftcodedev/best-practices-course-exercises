using System;
using System.Collections.Generic;

namespace elearning.Shared.Domain
{
    public abstract class DateTimeValueObject : ValueObject
    {
        public DateTime Value { get; }

        public DateTimeValueObject(DateTime value)
        {
            Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }
    }
}