using System;

namespace Ninject461.Weapon
{
    public class Crowbar : IWeapon
    {
        public void Hit(string target)
        {
            Console.WriteLine($"Struck at {target} with the trusty old crowbar");
        }
    }
}