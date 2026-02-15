using System;
using FactoryMethodTransportSystem.Interfaces;

namespace FactoryMethodTransportSystem.Vehicles
{
    public class Truck : IVehicle
    {
        private int capacity;
        private int axles;

        public Truck(int capacity, int axles)
        {
            this.capacity = capacity;
            this.axles = axles;
        }

        public void Drive()
        {
            Console.WriteLine($"Грузовик {capacity} тонн, осей: {axles} едет");
        }

        public void Refuel()
        {
            Console.WriteLine($"Грузовик {capacity} тонн заправляется");
        }
    }
}
