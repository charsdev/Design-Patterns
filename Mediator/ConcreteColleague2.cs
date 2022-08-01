using System;
using System.Collections.Generic;

namespace Mediator
{

    public class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.Write("Colleague 2 " + message);
        }
    }
}
