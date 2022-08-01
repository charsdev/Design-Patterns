using System;
using System.Collections.Generic;

namespace Observer
{
    public interface ISubject<T>
    {
        void Subscribe(IObserver<T> observer);
        void Unsubscribe(IObserver<T> observer);
        void Notify();
        T GetSubject();
    }
}
