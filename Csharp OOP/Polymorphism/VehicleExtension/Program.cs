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
            double capacity = double.Parse(carStrings[3]);
            Vehicle carVehicle = new Car(quantity, meters, capacity);

            string[] truckStrings = Console.ReadLine().Split().ToArray();

            double tquantity = double.Parse(truckStrings[1]);
            double tmeters = double.Parse(truckStrings[2]);
            double tcapacity = double.Parse(truckStrings[3]);
            Vehicle truckVehicle = new Truck(tquantity, tmeters, tcapacity);

            string[] busStrings = Console.ReadLine().Split().ToArray();

            double bquantity = double.Parse(busStrings[1]);
            double bmeters = double.Parse(busStrings[2]);
            double bcapacity = double.Parse(busStrings[3]);
            var busVehicle = new Bus(bquantity, bmeters, bcapacity);

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
                    else if (command[1] == "Bus")
                    {
                        double distance = double.Parse(command[2]);

                        busVehicle.Drive(distance);
                    }
                }
                else if (command[0] == "Refuel")
                {
                    if (command[1] == "Car")
                    {
                        double liters = double.Parse(command[2]);

                        if (liters <= 0)
                        {
                            Console.WriteLine("Fuel must be a positive number");
                        }
                        else
                        {
                            carVehicle.Refuel(liters);
                        }

                    }
                    else if (command[1] == "Truck")
                    {
                        double liters = double.Parse(command[2]);

                        if (liters <= 0)
                        {
                            Console.WriteLine("Fuel must be a positive number");
                        }

                        truckVehicle.Refuel(liters);
                    }
                    else if (command[1] == "Bus")
                    {
                        double liters = double.Parse(command[2]);

                        if (liters <= 0)
                        {
                            Console.WriteLine("Fuel must be a positive number");
                        }

                        busVehicle.Refuel(liters);
                    }
                }
                else if (command[0] == "DriveEmpty")
                {
                    double distance = double.Parse(command[2]);

                    busVehicle.DriveEmpty(distance);
                }
            }

            Console.WriteLine($"Car: {carVehicle.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truckVehicle.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {busVehicle.FuelQuantity:f2}");


        }
    }
}
