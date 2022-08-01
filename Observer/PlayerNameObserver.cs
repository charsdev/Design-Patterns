using System;
using System.Collections.Generic;

namespace Observer
{
    public class PlayerNameObserver : IObserver<Player>
    {
        public void OnNotify(ISubject<Player> subject)
        {
            Console.WriteLine("Player new Name:" + subject.GetSubject().Name);
        }     
    }
}
