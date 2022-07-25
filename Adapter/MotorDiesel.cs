using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{

    public class MotorDiesel : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando Motor Diesel");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando Motor Diesel");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando Motor Diesel");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo Motor Diesel");
        }
    }
}
