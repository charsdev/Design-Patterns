using System;

namespace Factory
{
    public class ConexionSQLServer : IConexion
    {
		private readonly string _host;
		private readonly string _puerto;
		private readonly string _usuario;
		private readonly string _contrasena;

		public ConexionSQLServer()
		{
			_host = "local_host";
			_puerto = "3306";
			_usuario = "root";
			_contrasena = "123";
		}

		public void Conectar()
		{
			Console.WriteLine("Se conectó a MySQL");
		}

		public void Desconectar()
		{
			Console.WriteLine("Se desconectó de MySQL");
		}

		public override string ToString()
		{
			return "ConexionMySQL [_host=" + _host + ", _puerto=" + _puerto + ", _usuario=" + _usuario + ", _contrasena="
					+ _contrasena + "]";
		}
	}
}