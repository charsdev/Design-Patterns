using System;
using System.Collections.Generic;

namespace NullObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Character chars = new Character();
            List <Weapon> weapons = new List<Weapon>();
            weapons.Add(new NormalWeapon());
            weapons.Add(new SpecialWeapon());
            weapons.Add(new NullWeapon()); // this dont do anything

            foreach (var item in weapons)
            {
                chars.PickUpWeapon(item);
                chars.Attack();
            }

        }
    }
}
