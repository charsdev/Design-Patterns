using System;

namespace Bridge
{

    public class RadioSwitchButton : SwitchButton
    {
        public RadioSwitchButton(ISwitcheable switcheable) : base(switcheable)
        {
        }

        public override void Toogle()
        {
            Console.WriteLine("Toogle Radio");
            base.Toogle();
        }
    }
}
