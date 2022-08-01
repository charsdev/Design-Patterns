using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        private const int BranchAmount = 5;
        private const int LeafAmount = 10;

        static void Main(string[] args)
        {
            Composite Tree = new Composite();
            var Root = new Root();

            Root.Trunk.Branches = new Composite();

            for (int i = 0; i < BranchAmount; i++)
            {
                Branch branch = new Branch();
                Root.Trunk.Branches.Add(branch);

                for (int j = 0; j < LeafAmount; j++)
                {
                    branch.Leafs.Add(new Leaf());
                }
            }

            Tree.Add(Root);
            Tree.Execute();
        }
    }
}
