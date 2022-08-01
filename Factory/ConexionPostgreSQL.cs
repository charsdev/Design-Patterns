using System;

namespace Factory
{
    public class ConexionPostgreSQL : IConexion
    {
		private readonly string _host;
		private readonly string _puerto;
		private readonly string _usuario;
		private readonly string _contrasena;

		public ConexionPostgreSQL()
		{
			_host = "local_host";
			_puerto = "5433";
			_usuario = "postgres";
			_contrasena = "123";
		}

		public void Conectar()
		{
			Console.WriteLine("Se conectó a PostgreSQL");
		}

		public void Desconectar()
		{
			Console.WriteLine("Se desconectó de PostgreSQL");
		}

		public override string ToString()
		{
			return "PostgreSQL [_host=" + _host + ", _puerto=" + _puerto + ", _usuario=" + _usuario + ", _contrasena="
					+ _contrasena + "]";
		}
	}
}