using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Memento
{

    public class CareTaker<T>
    {
        private readonly List<Memento<T>> _history;
        private readonly Originator<T> _originator = null;

        public CareTaker(Originator<T> originator)
        {
            _history = new List<Memento<T>>();
            _originator = originator;
        }

        public void Backup()
        {
            _history.Add(_originator.Save());
        }

        public void Add(Memento<T> state)
        {
            _history.Add(state);
        }

        public Memento<T> this[int index]
        {
            get { return _history[index]; }
        }
    }

  
}
