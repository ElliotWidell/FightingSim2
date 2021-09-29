using System;
using System.Collections.Generic;

namespace FightingSim2
{

    public class Hero
    {
        public int hp = generator.Next(70, 130);
        public static List<string> heroNames = new List<string>(){
            "Elliot", "Aironas", "Arda", "Rambo", "Osama Binladen"
        };

        public string name;

        private static Random generator = new Random();

        public Weapon weapon = new Weapon();

        public Hero()
        {
            int heroNameNumber1 = generator.Next(heroNames.Count);
            name = heroNames[heroNameNumber1];

        }

        public void Attack(Hero target)
        {
            target.hp -= weapon.weaponDmg;
        }

    }
}