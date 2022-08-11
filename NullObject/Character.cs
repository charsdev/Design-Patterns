using System;
using System.Collections.Generic;

namespace NullObject
{

    public class Character
    {
        private Weapon currentWeapon;

        public void PickUpWeapon(Weapon weapon)
        {
            currentWeapon = weapon;
        }

        public void Attack()
        {
            currentWeapon.Attack(this);
        }
    }
}
