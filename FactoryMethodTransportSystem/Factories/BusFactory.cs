using FactoryMethodTransportSystem.Interfaces;
using FactoryMethodTransportSystem.Vehicles;

namespace FactoryMethodTransportSystem.Factories
{
    public class BusFactory : VehicleFactory
    {
        private int seats;
        private string route;

        public BusFactory(int seats, string route)
        {
            this.seats = seats;
            this.route = route;
        }

        public override IVehicle CreateVehicle()
        {
            return new Bus(seats, route);
        }
    }
}
