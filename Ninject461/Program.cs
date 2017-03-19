using System;
using System.Reflection;
using Ninject;
using Ninject461.Warrior;

namespace Ninject461
{
    public static class Program
    {
        public static void Main()
        {
            IKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());

            var grunt = kernel.Get<Grunt>();
            var sniper = kernel.Get<Sniper>();
            var ninja = kernel.Get<Ninja>();
            var noob1 = kernel.Get<Noob>();

            grunt.Attack("the bad ones nearby");
            sniper.Attack("the bad ones farther away");
            ninja.Attack("the ones who didn't expect it");
            noob1.Attack("the zombies");

            Console.ReadKey();
        }
    }
}