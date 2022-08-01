using System;
using System.Collections.Generic;

namespace Visitor
{


    public class OperationVisitor 
    {
        public void Execute(List<IOperation> operations)
        {
            foreach (var operation in operations)
            {
                Execute(operation);
            }
        }

        public void Execute(IOperation operation)
        {
            operation.Accept(this);
        }

        public void Visit(ConcreteOperationSub component)
        {
            component.Execute(1, 2);
        }

        public void Visit(ConcreteOperationSum component)
        {
            component.Execute(1, 3);
        }

    }
}
