using System;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IOperation> operations = new List<IOperation>()
            {
                new ConcreteOperationSub(),
                new ConcreteOperationSum()
            };

            OperationVisitor visitor = new OperationVisitor();
            visitor.Execute(operations);
        }
    }
}
