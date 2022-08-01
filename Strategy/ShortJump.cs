using System;

namespace Strategy
{
    class ShortJump : IJumpBehavior
    {
        public void Jump()
        {
            Console.WriteLine("Short Jump");
        }
    }
}
  

