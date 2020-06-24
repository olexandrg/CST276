using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameLib
{
    public class Queen : Character
    {
        public override void Fight()
        {
            Console.WriteLine("Queen is fighting");
            Weapon.UseWeapon();
        }
    }
}
