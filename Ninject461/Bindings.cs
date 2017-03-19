using Ninject.Modules;
using Ninject461.Ammo;
using Ninject461.Weapon;

namespace Ninject461
{
    public class Bindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IWeapon>().To<Gun>().Named("Grunt");
            Bind<IWeapon>().To<Rifle>().Named("Sniper");
            Bind<IWeapon>().To<Sword>().Named("Ninja");
            Bind<IWeapon>().To<Crowbar>().Named("Noob");

            Bind<IAmmo>().To<ApAmmo>().Named("AP");
            Bind<IAmmo>().To<TungstenAmmo>().Named("Tungsten");
        }
    }
}