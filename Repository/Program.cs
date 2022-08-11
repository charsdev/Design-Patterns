using System;
using System.Collections.Generic;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            Character character = new Character();
            character.CharacterId = 0;
            character.Name = "Chars The Burned";
            character.Level = 1;
            character.Gender = "Male";
            character.Class = "Dark Wizard";

            CharacterRepository characterRepository = new CharacterRepository();
            characterRepository.Insert(character);
            characterRepository.Save();

            foreach (var c in characterRepository.GetAll())
            {
                Console.WriteLine(c.ToString());
            }

            Console.WriteLine("\nPress any key to level up...");
            Console.ReadLine();

            character.Level = 500;
            character.Class = "Soul Master";
            character.Zen = 99999999999;
            characterRepository.Update(character);
            characterRepository.Save();

            Console.WriteLine(characterRepository.GetById(0).ToString());

            Console.WriteLine("\nPress any key to Exit...");
            Console.ReadLine();
        }
    }
}
