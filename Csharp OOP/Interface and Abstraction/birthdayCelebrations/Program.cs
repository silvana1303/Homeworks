using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;

namespace borderControl
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] passengers = Console.ReadLine().Split().ToArray();

            List<string> identification = new List<string>();

            while (passengers[0] != "End")
            {
                if (passengers[0] == "Robot")
                {
                    string model = passengers[1];
                    string id = passengers[2];

                    Robot robot = new Robot(model, id);

                }
                else if (passengers[0] == "Pet")
                {
                    string name = passengers[1];
                    string birthdate = passengers[2];

                    Pet pet = new Pet(name, birthdate);
                    identification.Add(pet.Birthdate);
                }
                else if(passengers[0] == "Citizen")
                {
                    string name = passengers[1];
                    int age = int.Parse(passengers[2]);
                    string id = passengers[3];
                    string birthdate = passengers[4];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    identification.Add(citizen.Birthdate);

                }

                passengers = Console.ReadLine().Split().ToArray();
            }

            string input = Console.ReadLine();

            int count = 0;

            foreach (var id in identification)
            {
                // Regex re = new Regex(@"(\d+)[^\d]*$");
                // Match m = re.Match(input);
                //
                // if (m.Success)
                // {
                //     Console.WriteLine(id);
                // }

                if (id.EndsWith(input))
                {
                    Console.WriteLine(id);
                    count++;
                }
               
            }

            if (count == 0)
            {
                Console.WriteLine("");
            }
        }
    }
}
