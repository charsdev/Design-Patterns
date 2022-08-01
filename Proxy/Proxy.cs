using System;
using System.Linq;
using System.Reflection;

namespace Proxy
{

    public class Proxy : ISubject 
    {
        private Subject _subject;

        public Proxy(Subject subject)
        {
            _subject = subject;
        }

        private void CheckSubject()
        {
            if (_subject == null)
            {
                _subject = new Subject();
            }
        }

        public void DoSomething()
        {
            CheckSubject();
            _subject.DoSomething();
            Console.WriteLine("bro");
        }

    }
}
