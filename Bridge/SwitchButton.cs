using System;

namespace Bridge
{

    public abstract class SwitchButton
    {
        protected readonly ISwitcheable _switcheable;

        protected SwitchButton(ISwitcheable switcheable)
        {
            _switcheable = switcheable;
        }

        public virtual void Toogle()
        {
            if (!_switcheable.GetState())
                _switcheable.TurnOn();
            else
                _switcheable.TurnOff();
        }
    }
}
