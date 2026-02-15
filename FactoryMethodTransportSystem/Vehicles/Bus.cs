using System;
using FactoryMethodTransportSystem.Interfaces;

namespace FactoryMethodTransportSystem.Vehicles
{
    public class Bus : IVehicle
    {
        private int seats;
        private string route;

        public Bus(int seats, string route)
        {
            this.seats = seats;
            this.route = route;
        }

        public void Drive()
        {
            Console.WriteLine($"Автобус на {seats} мест едет по маршруту {route}");
        }

        public void Refuel()
        {
            Console.WriteLine($"Автобус {route} заправляется");
        }
    }
}
