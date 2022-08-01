using System;

namespace Bridge
{

    public class Television : ISwitcheable
    {
        private bool State;

        public bool GetState()
        {
            return State;
        }

        public void TurnOff()
        {
            State = false;
        }

        public void TurnOn()
        {
            State = true;
        }
    }
}
