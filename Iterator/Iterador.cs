using System;

namespace Iterator
{
    partial class Program
    {
        public class Iterador<T> : IIterator<T>
        {
            private readonly T[] _people;
            private int position = -1;

            public Iterador(T[] list)
            {
                _people = list;
            }

            public T Next
            {
                get
                {
                    if (HasMore())
                    {
                        position++;
                    }
                    return _people[position];
                }
            }

            public bool HasMore() => position < _people.Length - 1;
        }
    }
}
