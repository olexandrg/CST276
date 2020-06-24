using AdventureGameLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiate new weapons
            IWeaponBehavior bowAndArrorWeapon = new BowAndArrow();
            IWeaponBehavior knifeWeapon = new Knife();
            IWeaponBehavior axeWeapon = new Axe();


            // instantiate new character from class King and fight with Bow & Arrow
            Character kingCharacter = new King();
            kingCharacter.Weapon = bowAndArrorWeapon;
            kingCharacter.Fight();

            // instantiate new character from class Troll and fight with Knife
            Character trollCharacter = new Troll();
            trollCharacter.Weapon = knifeWeapon;
            trollCharacter.Fight();

            // instantiate new character from class Queen and fight with Axe
            Character queenCharacter = new Queen();
            queenCharacter.Weapon = axeWeapon;
            queenCharacter.Fight();

            //output to console
            Console.ReadLine();
        }
    }
}
