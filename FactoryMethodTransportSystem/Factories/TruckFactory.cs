using FactoryMethodTransportSystem.Interfaces;
using FactoryMethodTransportSystem.Vehicles;

namespace FactoryMethodTransportSystem.Factories
{
    public class TruckFactory : VehicleFactory
    {
        private int capacity;
        private int axles;

        public TruckFactory(int capacity, int axles)
        {
            this.capacity = capacity;
            this.axles = axles;
        }

        public override IVehicle CreateVehicle()
        {
            return new Truck(capacity, axles);
        }
    }
}
