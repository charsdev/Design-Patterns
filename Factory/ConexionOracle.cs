using System;

namespace Factory
{
    public class ConexionOracle : IConexion
    {
		private readonly string _host;
		private readonly string _puerto;
		private readonly string _usuario;
		private readonly string _contrasena;

		public ConexionOracle()
		{
			_host = "local_host";
			_puerto = "1521";
			_usuario = "admin";
			_contrasena = "123";
		}

		public void Conectar()
		{
			Console.WriteLine("Se conectó a Oracle");
		}

		public void Desconectar()
		{
			Console.WriteLine("Se desconectó de Oracle");
		}

		public override string ToString()
		{
			return "ConexionOracle [_host=" + _host + ", _puerto=" + _puerto + ", _usuario=" + _usuario + ", _contrasena="
					+ _contrasena + "]";
		}
	}
}