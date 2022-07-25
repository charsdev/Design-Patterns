using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Motor[] motores = new Motor[] {
                new MotorDiesel(),
                new MotorElectricoAdapter(),
                new MotorNafta()
            };

            for (int i = 0; i < motores.Length; i++)
            {
                Motor motorActual = motores[i];
                motorActual.Arrancar();
                motorActual.Acelerar();
                motorActual.Detener();
                motorActual.CargarCombustible();
                Console.WriteLine();
            }
        
        }
    }
}
