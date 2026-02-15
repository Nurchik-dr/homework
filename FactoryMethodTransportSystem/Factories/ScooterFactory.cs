using FactoryMethodTransportSystem.Interfaces;
using FactoryMethodTransportSystem.Vehicles;

namespace FactoryMethodTransportSystem.Factories
{
    public class ScooterFactory : VehicleFactory
    {
        private string battery;
        private int speed;

        public ScooterFactory(string battery, int speed)
        {
            this.battery = battery;
            this.speed = speed;
        }

        public override IVehicle CreateVehicle()
               {
            return new Scooter(battery, speed);
        }
    }
}
