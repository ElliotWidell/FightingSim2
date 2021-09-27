using System;
using System.Collections.Generic;

namespace FightingSim2
{
    public class Hero
    {
        public int hp = 100;
        public List<string> heroNames = new List<string>(){
            "Elliot", "Aironas", "Arda", "Rambo", "Osama Binladen"
        };

        public string name;

        private Random generator = new Random();

        public Hero()
        {
            int heroNameNumber1 = generator.Next(heroNames.Count);
            name = heroNames[heroNameNumber1];

        }

    }
}