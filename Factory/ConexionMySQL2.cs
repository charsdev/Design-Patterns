using System;

namespace Factory
{
	public class ConexionMySQL2 : IConexion
	{
		private readonly string _host;
		private readonly string _puerto;
		private readonly string _usuario;
		private readonly string _contrasena;

		public ConexionMySQL2()
		{
			_host = "local_host";
			_puerto = "3306";
			_usuario = "root";
			_contrasena = "123";
		}

		public void Conectar()
		{
			Console.WriteLine("Se conectó a MySQL2");
		}

		public void Desconectar()
		{
			Console.WriteLine("Se desconectó de MySQL2");
		}

		public override string ToString()
		{
			return "ConexionMySQL2 [_host=" + _host + ", _puerto=" + _puerto + ", _usuario=" + _usuario + ", _contrasena="
					+ _contrasena + "]";
		}
	}
}