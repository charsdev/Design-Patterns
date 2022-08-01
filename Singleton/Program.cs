using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Conexion c = Conexion.GetInstance();
            c.Conectar();
            c.Desconectar();
        }
    }
}
