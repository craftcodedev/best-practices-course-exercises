using System;
using System.Collections.Generic;

namespace BlockbusterApp.src.Shared.Domain
{
    public abstract class DateTimeValueObject : ValueObject
    {
        private DateTime value;

        public DateTimeValueObject(DateTime value)
        {
            this.value = value;
        }

        public DateTime GetValue()
        {
            return this.value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.value;
        }
    }
}
