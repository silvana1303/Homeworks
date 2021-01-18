using System;
using System.Linq;

namespace Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] carStrings = Console.ReadLine().Split().ToArray();

            double quantity = double.Parse(carStrings[1]);
            double meters = double.Parse(carStrings[2]);

            Vehicle carVehicle = new Car(quantity, meters);

            string[] truckStrings = Console.ReadLine().Split().ToArray();

            double tquantity = double.Parse(truckStrings[1]);
            double tmeters = double.Parse(truckStrings[2]);

            Vehicle truckVehicle = new Truck(tquantity, tmeters);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string[] command = Console.ReadLine().Split().ToArray();

                if (command[0] == "Drive")
                {
                    if (command[1] == "Car")
                    {
                        double distance = double.Parse(command[2]);

                        carVehicle.Drive(distance);
                    }
                    else if (command[1] == "Truck")
                    {
                        double distance = double.Parse(command[2]);

                        truckVehicle.Drive(distance);
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        double liters = double.Parse(command[2]);

                        carVehicle.Refuel(liters);
                    }
                    else if (command[1] == "Truck")
                    {
                        double liters = double.Parse(command[2]);

                        truckVehicle.Refuel(liters);
                    }
                }
            }

            Console.WriteLine($"Car: {carVehicle.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truckVehicle.FuelQuantity:f2}");


        }
    }
}
