using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Television television = new Television();
            Radio radio = new Radio();
            SwitchButton TVSwitch = new TVSwitchButton(television);
            SwitchButton radioSwitch = new RadioSwitchButton(radio);

            TVSwitch.Toogle();
            Console.WriteLine($"Television is {PrintState(television)}");
            TVSwitch.Toogle();
            Console.WriteLine($"Television is {PrintState(television)}");

            Console.WriteLine("------------------------------");

            radioSwitch.Toogle();
            Console.WriteLine($"Radio is {PrintState(radio)}");
            radioSwitch.Toogle();
            Console.WriteLine($"Radio is {PrintState(radio)}");

            Console.ReadKey();
            string PrintState(ISwitcheable switcheable) => switcheable.GetState() ? "On" : "Off";
        }
    }
}
