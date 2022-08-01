using System;
using System.Linq;
using System.Reflection;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            
            Proxy proxy = new Proxy(subject);
            proxy.DoSomething();
        }
    }
}
