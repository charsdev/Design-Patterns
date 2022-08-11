using System;

namespace Optional
{


    public interface IWeaponRepository
    {
        Optional<Weapon> GetWeaponById(int id);
    }
}
