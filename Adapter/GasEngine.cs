using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class GasEngine : Engine
    {
        public override void Accelerate()
        {
            Console.WriteLine("Accelerating Gas Engine...");
        }

        public override void Start()
        {
            Console.WriteLine("Starting Gas Engine...");
        }

        public override void Refuel()
        {
            Console.WriteLine("Refuel Gas Engine");
        }

        public override void Stop()
        {
            Console.WriteLine("Stopping Gas Engine...");
        }
    }
}
