using System;
using System.Collections.Generic;

namespace Flyweight
{

    //FlyWeight Interface with operations
    public interface IPlayer
    {
        public void AssignWeapon(string weapon);
        public void SendMission();
    }
}