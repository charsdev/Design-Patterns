using System;

namespace Memento
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            string talk = "hello";
            History<string> history = new History<string>();
            history.Save(talk);
            Console.WriteLine(talk);
            talk = "how";
            history.Save(talk);
            Console.WriteLine(talk);
            talk = "bye";
            history.Save(talk);
            Console.WriteLine(talk);
            Console.WriteLine(history.RestoreCheckPoint(0));

            Account account = new Account("Admin", "123", "email@invalid.com");
            Console.WriteLine(account.ToString());
            History<Account> history2 = new History<Account>();
            history2.Save(account);

            account.Password = "test";
            account.Email = "emaiasdadsl@valid.com";
            history2.Save(account);

            account.Password = "test2";
            account.Email = "email2@valid.com";
            history2.Save(account);

            Console.WriteLine(history2.RestoreCheckPoint(0));
            Console.WriteLine(history2.RestoreCheckPoint(1));
            Console.WriteLine(history2.RestoreCheckPoint(2));
        }
    }
}
