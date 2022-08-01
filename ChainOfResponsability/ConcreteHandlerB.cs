using System;

namespace ChainOfResponsability
{

    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(int request)
        {
            Console.WriteLine("B");
            base.HandleRequest(request+1);
        }
    }

}
