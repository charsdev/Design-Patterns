using System;
using System.Collections.Generic;

namespace Visitor
{

    public interface IOperation
    {
        void Accept(OperationVisitor visitor);
    }
}
