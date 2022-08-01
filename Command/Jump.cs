using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Command
{
    public class Jump : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Jump");
        }
    }
}
