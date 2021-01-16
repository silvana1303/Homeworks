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
                if (passengers.Length == 2)
                {
                    string model = passengers[0];
                    string id = passengers[1];

                    Robot robot = new Robot(model, id);
                    identification.Add(robot.Id);

                }
                else
                {
                    string name = passengers[0];
                    int age = int.Parse(passengers[1]);
                    string id = passengers[2];

                    Citizen citizen = new Citizen(name, age, id);
                    identification.Add(citizen.Id);

                }

                passengers = Console.ReadLine().Split().ToArray();
            }

            string input = Console.ReadLine();

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
                }
            }
        }
    }
}
