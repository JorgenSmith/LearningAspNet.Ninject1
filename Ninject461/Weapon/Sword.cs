using System;

namespace Ninject461.Weapon
{
    public class Sword : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"Chopped {target} clean in half");
        }
    }
}