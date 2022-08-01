using System;

namespace Bridge
{

    public interface ISwitcheable
    {
        void TurnOn();
        void TurnOff();
        bool GetState();
    }
}
