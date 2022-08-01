using System;
using System.Collections.Generic;

namespace Observer
{
    public interface IObserver<T>
    {
        void OnNotify(ISubject<T> subject);
    }
}
