using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameLib
{
    public class King : Character
    {
        public override void Fight()
        {
            Console.WriteLine("King is fighting");
            Weapon.UseWeapon();
        }
    }
}
