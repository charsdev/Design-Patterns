using System;

namespace Strategy
{

    public class TornadoKick : IKickBehavior
    {
        public void Kick()
        {
            Console.WriteLine("Tornado Kick");
        }
    }
}
  

