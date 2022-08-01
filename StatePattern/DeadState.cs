using System;
using System.Collections.Generic;

namespace State
{

    public class DeadState : State
    {
        public DeadState(IContext context) : base(context)
        {
        }

        public override void DoAction()
        {
            Console.WriteLine("Dead State: x_x");
        }
    }
}
