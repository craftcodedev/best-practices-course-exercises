using System;
using System.Collections.Generic;

namespace BlockbusterApp.src.Shared.Domain
{
    public abstract class StringValueObject : ValueObject
    {
        private string value;

        public StringValueObject(string value)
        {
            this.value = value;
        }

        public string GetValue()
        {
            return this.value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.value;
        }
    }
}
