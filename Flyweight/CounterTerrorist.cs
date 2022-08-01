using System;
using System.Collections.Generic;

namespace Flyweight
{

    public class CounterTerrorist : IPlayer
    {
        // Intrinsic Attribute
        private readonly string _task;

        // Extrinsic Attribute
        private string weapon;

        public CounterTerrorist()
        {
            _task = "DIFFUSE BOMB";
        }

        public void AssignWeapon(string weapon)
        {
            this.weapon = weapon;
        }

        public void SendMission()
        {
            Console.WriteLine("Counter Terrorist with weapon " + weapon + "|" + " Task is " + _task);
        }
    }
}