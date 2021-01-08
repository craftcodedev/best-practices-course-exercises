using System.Collections.Generic;

namespace elearning.Shared.Domain
{
    public abstract class StringValueObject : ValueObject
    {
        public string Value { get; }

        public StringValueObject(string value)
        {
            Value = value;
        }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Value;
        }

        public static string UppercaseFirst(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                return string.Empty;
            }

            char[] v = value.ToCharArray();
            v[0] = char.ToUpper(v[0]);

            return new string(v);
        }
    }
}