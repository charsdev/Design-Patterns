using System;
using System.Collections.Generic;

namespace NullObject
{

    public abstract class Weapon
    {
        public abstract void Attack(Character attacker);
        public abstract int Damage { get; }
    }
}
