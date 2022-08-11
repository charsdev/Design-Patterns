using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Engine[] engines = new Engine[] {
                new DieselEngine(),
                new ElectricEngineAdapter(),
                new GasEngine()
            };

            for (int i = 0; i < engines.Length; i++)
            {
                Engine current = engines[i];
                current.Start();
                current.Accelerate();
                current.Stop();
                current.Refuel();
                Console.WriteLine();
            }
        }
    }
}
