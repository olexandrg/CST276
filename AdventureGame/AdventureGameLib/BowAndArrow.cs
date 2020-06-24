using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameLib
{
    public class BowAndArrow : IWeaponBehavior
    {
        public void UseWeapon()
        {
            Console.WriteLine("Shot an arrow");
        }
    }
}
