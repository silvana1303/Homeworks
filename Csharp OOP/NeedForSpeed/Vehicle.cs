﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public abstract class Vehicle
    {
        protected Vehicle(int horsePower, double fuel)
        {
            this.Fuel = fuel;
            this.HorsePower = horsePower;
        }
        public virtual double DefaultFuelConsumption => 1.25;
        public virtual double FuelConsumption { get; set; }
        public double Fuel { get; set; }
        public int HorsePower { get; set; }

        public virtual void Drive(double kilometers)
        {
            this.Fuel -= kilometers * this.DefaultFuelConsumption;
        }
    }

   
}
