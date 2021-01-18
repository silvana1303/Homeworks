namespace Vehicles
{
    public interface IVehicle
    {
        public double FuelQuantity { get; }
        public double FuelConsumption { get; }
        public double TankCapacity { get; }


        void Drive(double distance);
        void Refuel(double liters);

    }
}