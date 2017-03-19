using System;
using Ninject;
using Ninject461.Weapon;

namespace Ninject461.Warrior
{
    public class Ninja : IWarrior
    {
        private readonly IWeapon _weapon;

        
        public Ninja([Named("Ninja")] IWeapon weapon)
        {
            if (weapon == null)
                throw new ArgumentException(nameof(weapon));

            _weapon = weapon;
        }

        public void Attack(string target)
        {
            _weapon.Hit(target);
        }
    }
}