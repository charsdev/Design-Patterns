using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Connection c = Connection.GetInstance();
            c.Connect();
            c.Disconect();
        }
    }
}
