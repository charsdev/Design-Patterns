using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Memento
{

    public class Memento<T>
    {
        public T State { get; private set; }

        public Memento(T state)
        {
            State = state; 
        }

       
    }

  
}
