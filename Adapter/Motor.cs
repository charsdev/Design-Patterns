using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    public abstract class Motor
    {
        public abstract void Acelerar();
        public abstract void Detener();
        public abstract void Arrancar();
        public abstract void CargarCombustible();
    }

    public class MotorElectrico
    {
        private bool _conectado;
        private bool _activo;
        private bool _moviendo;

        public void Conectar()
        {
            if (_conectado)
            {
                Console.WriteLine("Imposible conectar un motor ya conectado");
            }
            else
            {
                _conectado = true;
            }
        }

        public void Activar()
        {
            if (!_activo)
            {
                Console.WriteLine("Imposible activar un motor no conectado");
            }
            else
            {
                _activo = true;
            }
        }

        public void Mover()
        {
            if (!_conectado && !_activo)
            {
                Console.WriteLine("El motor debe estar conectado y activado");
            }
            else
            {
                Console.WriteLine("Moviendo vehiculo con motor eléctrico");
            }
        }

        public void Parar()
        {
            Console.WriteLine("El motor electrico se esta deteniendo");
        }

        public void Desconectar()
        {
            _conectado = false;
            Console.WriteLine("Moviendo vehiculo se ha desconectado");
        }

        public void Desactivar()
        {
            _activo = false;
            Console.WriteLine("El motor se ha desactivado");
        }

        public void Enchufar()
        {
            if (!_activo)
            {
                _activo = false;
                Console.WriteLine("Motor cargando baterias");
            }
            else
            {
                Console.WriteLine("Imposible enchufar un boton activo");
            }
        }
    }
}
