using System;
using System.Collections.Generic;

namespace Composite
{

    public class Leaf : INode
    {
        public void Execute(int i)
        {
            Console.WriteLine($"{i} Leaf");
        }
    }
}
