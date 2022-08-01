using System;
using System.Collections.Generic;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();

            //For testing purpose i will loop all the states and execute of my character
            foreach (var state in character.GetStates())
            {
                character.TransitionTo(state);
                character.Execute();
            }

            Console.ReadKey();
        }
    }
}
