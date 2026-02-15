using FactoryMethodTransportSystem.Interfaces;
using FactoryMethodTransportSystem.Vehicles;

namespace FactoryMethodTransportSystem.Factories
{
    public class MotorcycleFactory : VehicleFactory
    {
        private string type;
        private int volume;

        public MotorcycleFactory(string type, int volume)
        {
            this.type = type;
            this.volume = volume;
        }

        public override IVehicle CreateVehicle()
        {
            return new Motorcycle(type, volume);
        }
    }
}
