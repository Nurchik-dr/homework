using System;
using FactoryMethodTransportSystem.Interfaces;

namespace FactoryMethodTransportSystem.Vehicles
{
    public class Scooter : IVehicle
    {
        private string batteryType;
        private int maxSpeed;

        public Scooter(string batteryType, int maxSpeed)
        {
            this.batteryType = batteryType;
            this.maxSpeed = maxSpeed;
        }

        public void Drive()
        {
            Console.WriteLine($"Электросамокат едет. Скорость: {maxSpeed} км/ч");
        }

        public void Refuel()
        {
            Console.WriteLine($"Электросамокат заряжается. Батарея: {batteryType}");
        }
    }
}
