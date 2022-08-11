using System;

namespace Factory
{
	public class MySQL2Connection : IConnection
	{
		private readonly string _host;
		private readonly string _port;
		private readonly string _user;
		private readonly string _password;

		public MySQL2Connection()
		{
			_host = "local_host";
			_port = "3306";
			_user = "root";
			_password = "123";
		}

		public void Connect()
		{
			Console.WriteLine("Connected to MySQL2");
		}

		public void Disconnect()
		{
			Console.WriteLine("Disconnected from MySQL2");
		}

		public override string ToString()
		{
			return "MySQL2 [_host=" + _host + ", _port=" + _port + ", _user=" + _user + ", _password="
				+ _password + "]";
		}
	}
}