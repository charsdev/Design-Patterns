using System;

namespace Strategy
{

    class LongJump : IJumpBehavior
    {
        public void Jump()
        {
            Console.WriteLine("Long Jump");
        }
    }
}
  

