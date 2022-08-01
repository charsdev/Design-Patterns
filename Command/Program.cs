using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoker invoker = new Invoker();

            invoker.SetCommand(new Jump());
            invoker.ExecuteCommand();

            invoker.SetCommand(new Attack());
            invoker.ExecuteCommand();
        }
    }
}
