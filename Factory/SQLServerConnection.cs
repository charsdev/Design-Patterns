using System;

namespace Factory
{
    public class SQLServerConnection : IConnection
    {
		private readonly string _host;
		private readonly string _port;
		private readonly string _user;
		private readonly string _password;

		public SQLServerConnection()
		{
			_host = "local_host";
			_port = "3306";
			_user = "root";
			_password = "123";
		}

		public void Connect()
		{
			Console.WriteLine("Connected to SQLServer");
		}

		public void Disconnect()
		{
			Console.WriteLine("Disconnected from SQLServer");
		}

		public override string ToString()
		{
			return "SQLServer [_host=" + _host + ", _port=" + _port + ", _user=" + _user + ", _password="
				+ _password + "]";
		}
	}
}