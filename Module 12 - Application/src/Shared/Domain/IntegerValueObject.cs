using System.Collections.Generic;

namespace App.Shared.Domain
{
    public abstract class IntegerValueObject : ValueObject
    {
        private int value;

        public IntegerValueObject(int value)
        {
            this.value = value;
        }

        public int GetValue()
        {
            return this.value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return this.value;
        }
    }
}
