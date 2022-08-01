using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Conexion
    {
        private static Conexion instancia;

        private Conexion()
        {

        }

        public static Conexion GetInstance()
        {
            if (instancia == null)
            {
                instancia = new Conexion();
            }
            return instancia;
        }

        public void Conectar()
        {
            Console.WriteLine("Conectado a la Base de datos");
        }

        public void Desconectar()
        {
            Console.WriteLine("Desconectado de la Base de datos");
        }
    }
}
