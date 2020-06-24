﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGameLib
{
    public abstract class Character
    {
        public IWeaponBehavior Weapon;
        public abstract void Fight();
    }
}
