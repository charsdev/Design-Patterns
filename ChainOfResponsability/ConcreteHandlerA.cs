using System;

namespace ChainOfResponsability
{

    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(int request)
        {
            Console.WriteLine("A");
            base.HandleRequest(request+1);
        }
    }

}
