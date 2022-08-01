using System;
using System.Collections.Generic;

namespace Mediator
{

    public class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(IMediator mediator) : base(mediator)
        {
        }

        public override void Receive(string message)
        {
            Console.Write("Colleague 1 " + message);
        }
    }
}
