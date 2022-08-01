using System;
using System.Collections.Generic;

namespace Observer
{

    public class EnemyLifeObserver : IObserver<Enemy>
    {
        public void OnNotify(ISubject<Enemy> subject)
        {
            Console.WriteLine("Enemy current Life:" + subject.GetSubject().Life);
        }
    }
}
