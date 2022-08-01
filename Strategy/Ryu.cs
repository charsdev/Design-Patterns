using System;

namespace Strategy
{

    public class Ryu : Fighter
    {
        public Ryu(IKickBehavior kickBehavior, IJumpBehavior jumpBehavior) : base(kickBehavior, jumpBehavior)
        {
        }

        public override void Display()
        {
            Console.WriteLine("Ryu");
        }
    }
}
  

