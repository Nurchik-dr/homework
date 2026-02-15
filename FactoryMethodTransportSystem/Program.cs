using System;
using FactoryMethodTransportSystem.Factories;
using FactoryMethodTransportSystem.Interfaces;

namespace FactoryMethodTransportSystem
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Выберите транспорт:");
            Console.WriteLine("1 - Автомобиль");
            Console.WriteLine("2 - Мотоцикл");
            Console.WriteLine("3 - Грузовик");
            Console.WriteLine("4 - Автобус");
            Console.WriteLine("5 - Электросамокат");

            string choice = Console.ReadLine();
            VehicleFactory factory = null;

            if (choice == "1")
            {
                Console.Write("Марка: ");
                string brand = Console.ReadLine();

                Console.Write("Модель: ");
                string model = Console.ReadLine();

                Console.Write("Тип топлива: ");
                string fuel = Console.ReadLine();

                factory = new CarFactory(brand, model, fuel);
            }
            else if (choice == "2")
            {
                Console.Write("Тип мотоцикла: ");
                string type = Console.ReadLine();

                Console.Write("Объем двигателя: ");
                int volume = int.Parse(Console.ReadLine());

                factory = new MotorcycleFactory(type, volume);
            }
            else if (choice == "3")
            {
                Console.Write("Грузоподъемность: ");
                int cap = int.Parse(Console.ReadLine());

                Console.Write("Количество осей: ");
                int axles = int.Parse(Console.ReadLine());

                factory = new TruckFactory(cap, axles);
            }
            else if (choice == "4")
            {
                Console.Write("Количество мест: ");
                int seats = int.Parse(Console.ReadLine());

                Console.Write("Маршрут: ");
                string route = Console.ReadLine();

                factory = new BusFactory(seats, route);
            }
            else if (choice == "5")
            {
                Console.Write("Тип батареи: ");
                string battery = Console.ReadLine();

                Console.Write("Максимальная скорость: ");
                int speed = int.Parse(Console.ReadLine());

                factory = new ScooterFactory(battery, speed);
            }

            if (factory != null)
            {
                IVehicle vehicle = factory.CreateVehicle();
                vehicle.Drive();
                vehicle.Refuel();
            }
            else
            {
                Console.WriteLine("Неверный выбор");
            }
        }
    }
}
