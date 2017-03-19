using System;
using Ninject;
using Ninject461.Ammo;

namespace Ninject461.Weapon
{
    public class Gun : IWeapon
    {
        private readonly IAmmo _ammo;

        
        public Gun([Named("AP")] IAmmo ammo)
        {
            _ammo = ammo;
        }
        public void Hit(string target)
        {
            Console.WriteLine($"Gunned {target} to bits and pieces using {_ammo.YieldAmmoType()}");
        }
    }
}