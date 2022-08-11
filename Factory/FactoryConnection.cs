using System.Collections.Generic;

namespace Factory
{
    //Example OPEN CLOSE

    public class Connections
    {
        protected readonly Dictionary<string, IConnection> ConnectionContainer;

        public Dictionary<string, IConnection> GetConnectionContainer()
        {
            return ConnectionContainer;
        }

        public Connections()
        {
            ConnectionContainer = new Dictionary<string, IConnection>();
            ConnectionContainer.Add("MYSQL", new MySQLConection());
            ConnectionContainer.Add("ORACLE", new OracleConnection());
            ConnectionContainer.Add("SQLSERVER", new SQLServerConnection());
            ConnectionContainer.Add("POSTGRESQL", new PostSQLConnection());
        }
    }

    public class Connection2 : Connections
    {
        public Connection2()
        {
            ConnectionContainer.Add("MYSQL2", new MySQL2Connection());
        }
    }

	public class FactoryConnection
	{
        private readonly Dictionary<string, IConnection> _connections;

        public FactoryConnection(Dictionary<string, IConnection> connections)
        {
            _connections = connections;
        }

        public FactoryConnection(Connections connections)
        {
            _connections = connections.GetConnectionContainer();
        }

        public IConnection GetConnection(string engine) 
        {
            return !_connections.TryGetValue(engine, out IConnection connection) ? new EmptyConnection() : connection;
        }
    }
}