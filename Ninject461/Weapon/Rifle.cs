using System;
using Ninject;
using Ninject461.Ammo;

namespace Ninject461.Weapon
{
    public class Rifle : IWeapon
    {
        private readonly IAmmo _ammo;

        
        public Rifle( [Named("Tungsten")] IAmmo ammo)
        {
            _ammo = ammo;
        }
        public void Hit(string target)
        {
            Console.WriteLine($"Gunned {target} to bits and pieces using {_ammo.YieldAmmoType()}");
        }
    }
}