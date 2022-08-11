using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class DieselEngine : Engine
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating Diesel Engine...");
        }

        public override void Start()
        {
            Console.WriteLine("Starting Diesel Engine...");
        }

        public override void Refuel()
        {
            Console.WriteLine("Refuel Diesel Engine");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping Diesel Engine...");
        }
    }
}
