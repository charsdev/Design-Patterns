using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Command
{

    public class Attack : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Attack");
        }
    }
}
