using System;

namespace Optional
{
    public sealed class Optional<T> where T : class 
    {
        private readonly T value;

        public Optional(T value)
        {
            this.value = value;
        }

        public static Optional<T> Empty()
        {
            return new Optional<T>(null);
        }

        public bool IsPresent
        {
            get { return value != null; }
        }


        public void IfPresent(Action<T> action)
        {
            if (IsPresent) 
                action.Invoke(value);
        }

        public T OrElse(T elseValue)
        {
            return !IsPresent ? elseValue : value;
        }

        public T OrElseThrow(Exception exception)
        {
            return !IsPresent ? throw (exception) : value;
        }

    }
}
