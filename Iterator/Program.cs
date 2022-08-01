using System;
using System.Collections;
using System.Collections.Generic;

namespace Iterator
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("John", "Smith"),
                new Person("Jim", "Johnson"),
                new Person("Sue", "Rabon"),
            };

            People peopleList = new People(peopleArray);
            Foreach(peopleList, (p) => Console.WriteLine(p.FirstName + " " + p.LastName));

            //Local Function to Imitate Foreach with Generics
            static void Foreach<T>(Iterable<T> iterable, Action<T> action)
            {
                var iterator = iterable.CreateIterator();

                while (iterator.HasMore())
                {
                    action.Invoke(iterator.Next);
                }
            }
        }
    }
}
