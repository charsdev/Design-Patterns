using System;
using System.Collections.Generic;

namespace Composite
{

    internal class Root : INode
    {
        public Trunk Trunk;

        public Root()
        {
            Trunk = new Trunk();
        }

        public void Execute(int i)
        {
            Console.WriteLine($"{i} Root");
            Trunk.Execute(i);
        }
    }
}
