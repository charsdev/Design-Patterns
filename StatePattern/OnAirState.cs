using System;
using System.Collections.Generic;

namespace State
{

    public class OnAirState : State
    {
        public OnAirState(IContext context) : base(context)
        {
        }

        public override void DoAction()
        {
            Console.WriteLine("On Air State: Falling...");
        }
    }
}
