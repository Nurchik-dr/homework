using System;
using FactoryMethodTransportSystem.Interfaces;

namespace FactoryMethodTransportSystem.Vehicles
{
    public class Car : IVehicle
    {
        private string brand;
        private string model;
        private string fuelType;

        public Car(string brand, string model, string fuelType)
        {
            this.brand = brand;
            this.model = model;
            this.fuelType = fuelType;
        }

        public void Drive()
        {
            Console.WriteLine($"Автомобиль {brand} {model} едет. Топливо: {fuelType}");
        }

        public void Refuel()
        {
            Console.WriteLine($"Автомобиль {brand} {model} заправляется. Тип топлива: {fuelType}");
        }
    }
}
