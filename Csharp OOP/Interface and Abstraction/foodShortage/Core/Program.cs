using System;
using System.Collections.Generic;
using System.Linq;

namespace foodShortage
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = int.Parse(Console.ReadLine());

            HashSet<Citizen> citizenNames = new HashSet<Citizen>();
            HashSet<Rebel> rebelNames = new HashSet<Rebel>();

            Citizen citizen = null;
            Rebel rebel = null;

            for (int i = 0; i < times; i++)
            {
                string[] input = Console.ReadLine().Split().ToArray();

                if (input.Length == 3)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];

                    rebel = new Rebel(name, age, group);
                    rebelNames.Add(rebel);
                }
                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdate = input[3];

                    citizen = new Citizen(name, age, id, birthdate);
                    citizenNames.Add(citizen);
                }
            }

            int sum = 0;
            string command = Console.ReadLine();

            while (command != "End")
            {
                if (citizenNames.Any(x=>x.Name == command))
                {
                    Citizen x = citizenNames.FirstOrDefault(x => x.Name == command);
                    x.BuyFood();
                    sum += 10;
                }
                else if (rebelNames.Any(x => x.Name == command))
                {
                    Rebel x = rebelNames.FirstOrDefault(x => x.Name == command);
                    x.BuyFood();
                    sum += 5;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(sum);
        }
    }
}
