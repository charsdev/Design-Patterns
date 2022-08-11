using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Connection
    {
        private static Connection instance;

        private Connection()
        {

        }

        public static Connection GetInstance()
        {
            if (instance == null)
            {
                instance = new Connection();
            }
            return instance;
        }

        public void Connect()
        {
            Console.WriteLine("Connected to database");
        }

        public void Disconect()
        {
            Console.WriteLine("Disconected of database");
        }
    }
}
