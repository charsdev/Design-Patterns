using System;
using System.Collections.Generic;

namespace Flyweight
{
  
    public class PlayerFactory
    {
        private static Dictionary<string, IPlayer> _playerDictionary = new Dictionary<string, IPlayer>();

        // Method to get a player
        public static IPlayer GetPlayer(string type)
        {
            IPlayer p = null;

            if (!_playerDictionary.ContainsKey(type))
            {
                switch (type)
                {
                    case "Terrorist":
                        Console.WriteLine("Terrorist Created");
                        p = new Terrorist();
                        break;
                    case "CounterTerrorist":
                        Console.WriteLine("Counter Terrorist Created");
                        p = new CounterTerrorist();
                        break;
                }

                _playerDictionary.Add(type, p);
            }
            else
            {
                p = _playerDictionary[type];
            }

            return p;
        }
    }
}