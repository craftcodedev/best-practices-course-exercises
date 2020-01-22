namespace Model
{
    public abstract class ValueObject<T> where T : ValueObject<T>
    {
        protected string value;

        public string GetValue()
        {
            return value;
        }

        public override bool Equals(object obj)
        {
            var valueObject = obj as T;

            if (ReferenceEquals(valueObject, null))
                return false;

            if (GetType() != obj.GetType())
                return false;

            return EqualsCore(valueObject);
        }

        protected abstract bool EqualsCore(T other);
    }
}
