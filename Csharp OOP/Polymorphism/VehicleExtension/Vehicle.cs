namespace Vehicles
{
    public abstract class Vehicle : IVehicle
    {
       
        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            TankCapacity = tankCapacity;

            if (fuelQuantity > TankCapacity)
            {
                FuelQuantity = 0;
            }
            else
            {
                FuelQuantity = fuelQuantity;
            }

            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }
        
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

        public abstract void Drive(double distance);


        public abstract void Refuel(double liters);

    }
}