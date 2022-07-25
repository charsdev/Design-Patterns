using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{

    public class MotorNafta : Motor
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerando Motor base a nafta");
        }

        public override void Arrancar()
        {
            Console.WriteLine("Arrancando Motor base a nafta");
        }

        public override void CargarCombustible()
        {
            Console.WriteLine("Cargando Motor base a nafta");
        }

        public override void Detener()
        {
            Console.WriteLine("Deteniendo Motor base a nafta");
        }
    }
}
