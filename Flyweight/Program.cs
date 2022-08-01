using System;

namespace Flyweight
{
    internal static class Program
    {
        private const int AmountOfPlayer = 10;
        private static readonly string[] playerType = { "Terrorist", "CounterTerrorist" };
        private static readonly string[] weapons = { "AK-47", "Maverick", "Gut Knife", "Desert Eagle" };

        static void Main(string[] args)
        {
            for (int i = 0; i < AmountOfPlayer; i++)
            {
                IPlayer p = PlayerFactory.GetPlayer(GetRandArrayType(playerType));
                p.AssignWeapon(GetRandArrayType(weapons));
                p.SendMission();
            }

            Console.ReadKey();
        }

        public static T GetRandArrayType<T>(T[] arrType)
        {
            return arrType[new Random().Next(0, arrType.Length)];
        }
    }
}