using System;

namespace Bridge
{

    public class TVSwitchButton : SwitchButton
    {
        public TVSwitchButton(ISwitcheable switcheable) : base(switcheable)
        {
        }

        public override void Toogle()
        {
            Console.WriteLine("Toogle TV");
            base.Toogle();
        }
    }
}
