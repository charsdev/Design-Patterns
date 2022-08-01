using System;

namespace Facade
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            GameFacade gameFacade = new GameFacade();

            gameFacade.StartGame();
            gameFacade.AddScore();

            Console.ReadKey();
        }
    }
}
