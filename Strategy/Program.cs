using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            IJumpBehavior shortJump = new ShortJump();
            IJumpBehavior LongJump = new LongJump();
            IKickBehavior tornadoKick = new TornadoKick();

            Fighter ryu = new Ryu(tornadoKick, shortJump);
            ryu.Display();

            ryu.Punch();
            ryu.Kick();
            ryu.Jump();

            ryu.SetJumpBehavior(LongJump);
            ryu.Jump();
        }
    }
}
  

