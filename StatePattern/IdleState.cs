using System;
using System.Collections.Generic;

namespace State
{

    public class IdleState : State
    {
        public IdleState(IContext context) : base(context)
        {
        }

        public override void DoAction()
        {
            Console.WriteLine("Idle State: Doing nothing...");
        }
    }
}
