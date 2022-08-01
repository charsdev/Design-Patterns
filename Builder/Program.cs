using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Burger burger = new Burger.BurgerBuilder()
                .WithBacon()
                .WithCheese()
                .WithPatties(2)
                .WithLettuce()
                .WithPickles()
                .WithTomato()
                .Build();

            Console.WriteLine(burger.ToString());
            Console.ReadKey();
        }
    }
}
