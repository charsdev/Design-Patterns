using System;

namespace Iterator
{
    partial class Program
    {
        public class Iterable<T> : IIterable<T>
        {
            private readonly T[] _iterable;

            public Iterable(T[] pArray)
            {
                _iterable = new T[pArray.Length];

                for (int i = 0; i < pArray.Length; i++)
                {
                    _iterable[i] = pArray[i];
                }
            }

            public IIterator<T> CreateIterator()
            {
                return new Iterador<T>(_iterable);
            }
        }
    }
}
