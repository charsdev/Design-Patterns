using System;
using System.Collections.Generic;

namespace Observer
{

    public class Enemy : ISubject<Enemy>
    {
        private readonly List<IObserver<Enemy>> _observers;
        public int Life { get; private set; }

        public Enemy(int life)
        {
            Life = life;
            _observers = new List<IObserver<Enemy>>();
        }

        public Enemy GetSubject()
        {
            return this;
        }

        public void ApplyDamage(int damage)
        {
            Life -= damage;
            Notify();
        }

        public void Subscribe(IObserver<Enemy> observer)
        {
            _observers.Add(observer);
        }

        public void Unsubscribe(IObserver<Enemy> observer)
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
