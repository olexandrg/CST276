using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameLib
{
    public class Axe : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Axe goes clang.");
        }
    }
}
