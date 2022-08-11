using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkComponent coffeeWithSugar = new Sugar(new Coffe());
            Console.WriteLine(coffeeWithSugar.Description + " " + coffeeWithSugar.Cost);

            DrinkComponent teaWithMilk = new Milk(new Tea());
            Console.WriteLine(teaWithMilk.Description + " " + teaWithMilk.Cost);
        }
    }
}
