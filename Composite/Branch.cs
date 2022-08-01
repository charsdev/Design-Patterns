using System;
using System.Collections.Generic;

namespace Composite
{

    internal class Branch : INode
    {
        public Composite Leafs = new Composite();

        public void Execute(int i)
        {
            Console.WriteLine($"{i} Branch");
            Leafs.Execute();
        }
    }
}
