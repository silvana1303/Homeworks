using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    class RaceMotorcycle : Motorcycle
    {
        public RaceMotorcycle(int horsePower, int fuel) : base(horsePower, fuel)
        {
            
        }

        public override double DefaultFuelConsumption => 8;
    }
}
