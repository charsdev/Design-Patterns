using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Memento
{

    public class Originator<T>
    {
        public T State { get; set; }

        public Memento<T> Save()
        {
            return new Memento<T>(State);
        }

        public void Restore(Memento<T> memento)
        {
            State = memento.State;
        }

        
    }

  
}
