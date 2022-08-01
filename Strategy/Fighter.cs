using System;

namespace Strategy
{
    public abstract class Fighter
    {
        private IKickBehavior _kickBehavior;
        private IJumpBehavior _jumpBehavior;

        protected Fighter(IKickBehavior kickBehavior, IJumpBehavior jumpBehavior)
        {
            _jumpBehavior = jumpBehavior;
            _kickBehavior = kickBehavior;
        }

        public void Punch()
        {
            Console.WriteLine("Default Punch");
        }

        public void Kick()
        {
            _kickBehavior.Kick();
        }

        public void Jump()
        {
            _jumpBehavior.Jump();
        }

        public void Roll()
        {
            Console.WriteLine("Default Roll");
        }

        public void SetKickBehavior(IKickBehavior kickBehavior)
        {
           _kickBehavior = kickBehavior;
        }

        public void SetJumpBehavior(IJumpBehavior jumpBehavior)
        {
            _jumpBehavior = jumpBehavior;
        }

        public abstract void Display();
    }
}
  

