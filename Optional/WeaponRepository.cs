using System;

namespace Optional
{


    public class WeaponRepository : IWeaponRepository
    {
        public Optional<Weapon> GetWeaponById(int id)
        {
            return Optional<Weapon>.Empty();
        }
    }
}
