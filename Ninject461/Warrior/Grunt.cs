using System;
using Ninject;
using Ninject461.Weapon;

namespace Ninject461.Warrior
{
    public class Grunt : IWarrior
    {
        private readonly IWeapon _weapon;

        
        public Grunt([Named("Grunt")] IWeapon weapon)
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