using System;
using System.Collections.Generic;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            Colleague colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);
            mediator.Add(colleague1);
            mediator.Add(colleague2);
            colleague1.Communicate("This is a message from colleague 1");
            Console.ReadKey();
        }
    }
}
