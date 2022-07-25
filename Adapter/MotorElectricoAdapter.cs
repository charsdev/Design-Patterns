using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public class MotorElectricoAdapter : Motor
    {
        private readonly MotorElectrico _motor = new MotorElectrico();

        public override void Acelerar()
        {
            _motor.Mover();
        }

        public override void Arrancar()
        {
            _motor.Conectar();
            _motor.Activar();
        }

        public override void CargarCombustible()
        {
            _motor.Enchufar();
        }

        public override void Detener()
        {
            _motor.Desactivar();
            _motor.Parar();
        }
    }
}
