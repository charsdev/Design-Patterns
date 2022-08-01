using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cell> cells = new List<Cell>() { new Cell() };
            int n;

            do
            {
                Console.WriteLine("Enter the n times of mitosis");
                n = int.Parse(Console.ReadLine());

                for (int i = 0; i < n; i++)
                {
                    var clone = (Cell)cells[i].Clone();
                    cells.Add(clone);
                    Console.WriteLine(clone.ToString());
                }
            }
            while (n <= 0);
            Console.ReadLine();
        }
    }
}
