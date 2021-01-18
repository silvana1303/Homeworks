﻿using System;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Drive(double distance)
        {
            if (FuelQuantity >= (FuelConsumption + 1.6) * distance)
            {
                FuelQuantity -= (FuelConsumption + 1.6) * distance;

                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double liters)
        {
            FuelQuantity += 0.95 * liters;
        }
    }
}