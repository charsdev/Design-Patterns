using System;
using System.Collections.Generic;

namespace Composite
{

    internal class Trunk : INode
    {
        public Composite Branches = new Composite();

        public void Execute(int i)
        {
            Console.WriteLine($"{i} Trunk");
            Branches.Execute();
        }
    }
}
