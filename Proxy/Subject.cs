using System;
using System.Linq;
using System.Reflection;

namespace Proxy
{

    public class Subject : ISubject
    {
        public void DoSomething()
        {
            Console.WriteLine("hey!");
        }
    }
}
