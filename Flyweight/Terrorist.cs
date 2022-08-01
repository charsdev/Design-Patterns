using System;
using System.Collections.Generic;

namespace Flyweight
{

    public class Terrorist : IPlayer
    {
        // Intrinsic Attribute
        private readonly string _task;

        // Extrinsic Attribute
        private string weapon;

        public Terrorist()
        {
            _task = "PLANT A BOMB";
        }
        public void AssignWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public void SendMission()
        {
            Console.WriteLine("Terrorist with weapon " + weapon + "|" + " Task is " + _task);
        }
    }
}