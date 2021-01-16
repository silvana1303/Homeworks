using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace telephony
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phones = Console.ReadLine().Split().ToArray();
            string[] links = Console.ReadLine().Split().ToArray();

            StationaryPhone stationaryPhone = new StationaryPhone();
            Smartphone smartphone = new Smartphone();

            for (int i = 0; i < phones.Length; i++)
            {
                string phone = phones[i];

                Regex re = new Regex(@"\d+");
                Match m = re.Match(phone);

                if (m.Success)
                {
                    if (phone.Length == 7)
                    {
                        stationaryPhone.Call(phone);
                    }
                    else if (phone.Length == 10)
                    {
                        smartphone.Call(phone);
                    }
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }

            }

            for (int i = 0; i < links.Length; i++)
            {
                string link = links[i];

                Regex re = new Regex(@"\d+");
                Match m = re.Match(link);

                if (m.Success)
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    smartphone.Browse(link);
                }
            }
        }
    }
}
