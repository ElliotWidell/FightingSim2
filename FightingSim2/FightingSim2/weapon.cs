using System;
using System.Collections.Generic;

namespace FightingSim2
{
    public class Weapon
    {


        public List<string> weaponNames = new List<string>(){
            "Duskblade of draktharr", "Blade Of Woe", "Mehrunes razor", "Dawnbreaker"
        };
        public int weaponDmg;

        public string weaponName;

        private Random generator = new Random();

        public Weapon()
        {
            weaponDmg = generator.Next(5, 11);

            int weaponNameNumber = generator.Next(weaponNames.Count);
            weaponName = weaponNames[weaponNameNumber];


        }


    }
}