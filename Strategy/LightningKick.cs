using System;

namespace Strategy
{

    public class LightningKick : IKickBehavior
    {
        public void Kick()
        {
            Console.WriteLine("Lightning Kick");
        }
    }
}
  

