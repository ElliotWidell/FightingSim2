using System;
using System.Collections.Generic;

namespace FightingSim2
{
    class Program
    {
        static void Main(string[] args)
        {

            int roundNumb = 1;






            Hero h1 = new Hero();
            Hero h2 = new Hero();



            Console.WriteLine($"Fighter 1: {h1.name} HP: {h1.hp}");
            Console.WriteLine($"Fighter 2: {h2.name} HP: {h2.hp}");
            Console.WriteLine("Press ENTER to see the weapons");
            Console.ReadLine();
            Console.Clear();



            Console.WriteLine($"{h1.name} Weapon: {h1.weapon.weaponName} Dmg: {h1.weapon.weaponDmg}");
            Console.WriteLine($"{h2.name} Weapon: {h2.weapon.weaponName} Dmg: {h2.weapon.weaponDmg}");
            Console.WriteLine("Press ENTER to start the figth");
            Console.ReadLine();
            Console.Clear();





            while (h1.hp > 0 && h2.hp > 0)
            {

                Console.WriteLine($"Round: {roundNumb}");

                h1.Attack(h2);
                h2.Attack(h1);
                Console.WriteLine($"{h1.name} HP: {h1.hp}");
                Console.WriteLine($"{h2.name} HP: {h2.hp}");
                Console.ReadLine();
                Console.Clear();

                roundNumb++;
            }

            if (h1.hp > h2.hp)
            {
                Console.WriteLine($"{h1.name} Winns!!!");
            }
            else
            {


                Console.WriteLine($"{h2.name} Winns!!!");
            }


            Console.ReadLine();


        }







    }
}
