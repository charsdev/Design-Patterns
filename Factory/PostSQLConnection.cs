using System;

namespace Factory
{
    public class PostSQLConnection : IConnection
    {
		private readonly string _host;
		private readonly string _port;
		private readonly string _user;
		private readonly string _password;

		public PostSQLConnection()
		{
			_host = "local_host";
			_port = "5433";
			_user = "postgres";
			_password = "123";
		}

		public void Connect()
		{
			Console.WriteLine("Connected to PostgreSQL");
		}

		public void Disconnect()
		{
			Console.WriteLine("Disconnected from PostgreSQL");
		}

		public override string ToString()
		{
			return "PostgreSQL [_host=" + _host + ", _port=" + _port + ", _user=" + _user + ", _password="
					+ _password + "]";
		}
	}
}