using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            List<IBaseHero> heroes = new List<IBaseHero>();

            while(count > heroes.Count)
            {
                string name = Console.ReadLine();

                string type = Console.ReadLine();

                try
                {
                    if (type == "Druid")
                    {
                        BaseHero druid = new Druid(name);
                        heroes.Add(druid);
                        druid.CastAbility();
                    }
                    else if (type == "Paladin")
                    {
                        BaseHero paladin = new Paladin(name);
                        heroes.Add(paladin);
                        paladin.CastAbility();
                    }
                    else if (type == "Rogue")
                    {
                        BaseHero rogue = new Rogue(name);
                        heroes.Add(rogue);
                        rogue.CastAbility();
                    }
                    else if (type== "Warrior")
                    {
                        BaseHero warrior = new Warrior(name);
                        heroes.Add(warrior);
                        warrior.CastAbility();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid hero!");
                   
                }
               
            }

            int boss = int.Parse(Console.ReadLine());

            if (boss > heroes.Sum(x=>x.Power))
            {
                Console.WriteLine("Defeat..."); 
            }
            else
            {
                Console.WriteLine("Victory!");
            }
        }
    }
}
