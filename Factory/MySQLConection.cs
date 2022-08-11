using System;

namespace Factory
{
    public class MySQLConection : IConnection
    {
		private readonly string _host;
		private readonly string _port;
		private readonly string _user;
		private readonly string _password;

		public MySQLConection()
		{
			_host = "local_host";
			_port = "3306";
			_user = "root";
			_password = "123";
		}

		public void Connect()
		{
			Console.WriteLine("Se conectó a MySQL");
		}

		public void Disconnect()
		{
			Console.WriteLine("Se desconectó de MySQL");
		}

		public override string ToString()
		{
			return "MySQL [_host=" + _host + ", _port=" + _port + ", _user=" + _user + ", _password="
			+ _password + "]";
		}
	}
}