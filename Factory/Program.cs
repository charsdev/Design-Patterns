using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {

			Conexiones2 conexiones = new Conexiones2();
			ConexionFabrica fabrica = new ConexionFabrica(conexiones);

			IConexion cx1 = fabrica.GetConexion("ORACLE");
			cx1.Conectar();
			cx1.Desconectar();

			IConexion cx2 = fabrica.GetConexion("MYSQL");
			cx2.Conectar();
			cx2.Desconectar();

			IConexion cx3 = fabrica.GetConexion("H2");
			cx3.Conectar();
			cx3.Desconectar();

			IConexion cx4 = fabrica.GetConexion("MYSQL2");
			cx4.Conectar();
			cx4.Desconectar();
		}
    }

}

