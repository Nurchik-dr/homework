using FactoryMethodTransportSystem.Interfaces;

namespace FactoryMethodTransportSystem.Factories
{
    public abstract class VehicleFactory
    {
        public abstract IVehicle CreateVehicle();
    }
}
