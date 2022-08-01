using System;
using System.Collections.Generic;

namespace Visitor
{

    public class ConcreteOperationSum : IOperation
    {
        public void Accept(OperationVisitor visitor)
        {
            visitor.Visit(this);
        }

        public void Execute(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
