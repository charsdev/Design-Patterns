using System;

namespace ChainOfResponsability
{
    class Program
    {
        static void Main(string[] args)
        {
            var concreteHandlerA = new ConcreteHandlerA();
            var concreteHandlerB = new ConcreteHandlerB();
            var concreteHandlerC = new ConcreteHandlerC();

            concreteHandlerA
                .SetNextHandler(concreteHandlerB)
                .SetNextHandler(concreteHandlerC);

            int i = 0;
            concreteHandlerA.HandleRequest(i);
        }
    }
}
