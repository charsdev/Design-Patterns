using System;

namespace Optional
{
    class Program
    {
        static void Main(string[] args)
        {
            Weapon myWeapon = new Weapon();
            Optional<Weapon> test = new Optional<Weapon>(myWeapon);
            test.IfPresent((weapon) => weapon.DoAttack());

            Console.ReadLine();

            const int id = 1;
            WeaponRepository weaponRepository = new WeaponRepository();
            weaponRepository.GetWeaponById(id).OrElseThrow(new Exception($"Weapon with id {id} not found"));
        }
    }
}
