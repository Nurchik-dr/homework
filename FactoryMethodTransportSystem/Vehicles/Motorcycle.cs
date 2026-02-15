using System;
using FactoryMethodTransportSystem.Interfaces;

namespace FactoryMethodTransportSystem.Vehicles
{
    public class Motorcycle : IVehicle
    {
        private string type;
        private int engineVolume;

        public Motorcycle(string type, int engineVolume)
        {
            this.type = type;
            this.engineVolume = engineVolume;
        }

        public void Drive()
        {
            Console.WriteLine($"Мотоцикл ({type}) с объемом {engineVolume}cc едет");
        }

        public void Refuel()
        {
            Console.WriteLine($"Мотоцикл ({type}) заправляется");
        }
    }
}
