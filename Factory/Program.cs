using System;
using System.Collections.Generic;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
			Connection2 connections = new Connection2();
			FactoryConnection factory = new FactoryConnection(connections);

			IConnection cx1 = factory.GetConnection("ORACLE");
			cx1.Connect();
			cx1.Disconnect();

			IConnection cx2 = factory.GetConnection("MYSQL");
			cx2.Connect();
			cx2.Disconnect();

			IConnection cx3 = factory.GetConnection("H2");
			cx3.Connect();
			cx3.Disconnect();

			IConnection cx4 = factory.GetConnection("MYSQL2");
			cx4.Connect();
			cx4.Disconnect();
		}
    }

}

