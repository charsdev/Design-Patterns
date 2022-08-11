using System;
using System.Collections.Generic;

namespace NullObject
{

    public class NullWeapon : Weapon
    {
        public override void Attack(Character character)
        {

        }

        public override int Damage => 0;
    }
}
