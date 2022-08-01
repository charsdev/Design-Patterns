using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BebidaComponent cafeConAzucar = new Azucar(new Cafe());
            Console.WriteLine(cafeConAzucar.Descripcion + " " + cafeConAzucar.Costo);

            BebidaComponent teConLeche = new Leche(new Te());
            Console.WriteLine(teConLeche.Descripcion + " " + teConLeche.Costo);
        }
    }
}
