using System;
using System.Collections.Generic;

namespace NullObject
{

    public class SpecialWeapon : Weapon
    {
        public override void Attack(Character character)
        {
            Console.WriteLine($"Do {Damage} damage");
        }

        public override int Damage => 10;
    }
}
