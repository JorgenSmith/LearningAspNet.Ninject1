using System;
using Ninject;
using Ninject461.Weapon;

namespace Ninject461.Warrior
{
    public class Noob : IWarrior
    {
        private readonly IWeapon _weapon;

        public Noob([Named("Ninja")]IWeapon weapon)
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