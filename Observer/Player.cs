using System;
using System.Collections.Generic;

namespace Observer
{

    public class Player : ISubject<Player>
    {
        private readonly List<IObserver<Player>> _observers;

        public string Name { get; private set; }
        
        public Player(string name)
        {
            Name = name;
            _observers = new List<IObserver<Player>>();
        }

        public void SetName(string name)
        {
            Name = name;
            Notify();
        }

        public Player GetSubject()
        {
            return this;
        }

        public void Subscribe(IObserver<Player> observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver<Player> observer)
        {
            _observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.OnNotify(this);
            }
        }
    }
}
