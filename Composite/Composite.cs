using System;
using System.Collections.Generic;

namespace Composite
{

    public class Composite
    {
        private readonly List<INode> _nodes;

        public Composite()
        {
            _nodes = new List<INode>();
        }

        public void Add(INode node)
        {
            _nodes.Add(node);
        }

        public void Remove(INode node)
        {
            _nodes.Remove(node);
        }

        public void Execute()
        {
            int i = 0;
            foreach (INode node in _nodes)
            {
                node.Execute(i);
                i++;
            }
        }
    }
}
