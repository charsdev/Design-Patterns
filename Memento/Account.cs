using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Memento
{

    [Serializable]
    public class Account
    {
        public Account(string name, string password, string email)
        {
            Name = name;
            Password = password;
            Email = email;
        }

        public string Name { get; private set; }
        public string Password { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"Account Name: {Name}, Password: {Password}; Email: {Email}";
        }
    }

  
}
