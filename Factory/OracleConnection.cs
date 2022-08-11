using System;

namespace Factory
{
    public class OracleConnection : IConnection
    {
		private readonly string _host;
		private readonly string _port;
		private readonly string _user;
		private readonly string _password;

		public OracleConnection()
		{
			_host = "local_host";
			_port = "3306";
			_user = "root";
			_password = "123";
		}

		public void Connect()
		{
			Console.WriteLine("Connected to Oracle");
		}

		public void Disconnect()
		{
			Console.WriteLine("Disconnected from Oracle");
		}

		public override string ToString()
		{
			return "Oracle [_host=" + _host + ", _port=" + _port + ", _user=" + _user + ", _password="
					+ _password + "]";
		}
	}
}