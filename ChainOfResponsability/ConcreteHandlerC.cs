using System;

namespace ChainOfResponsability
{

    public class ConcreteHandlerC : Handler
    {
        public override void HandleRequest(int request)
        {
            Console.WriteLine("C");
            base.HandleRequest(request+1);
        }
    }

}
