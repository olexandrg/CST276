using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameLib
{
    public class Troll : Character
    {
        public override void Fight()
        {
            Console.WriteLine("Troll is fighting");
            Weapon.UseWeapon();
        }
    }
}
