using Logistic.Domain.Enums;
using Logistic.Domain.Factories;
using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;
using System;

namespace Logistic.Admin.UI
{
    internal class Menu
    {
        private IVehicleRepository vehicleRepository;
        private ITruckRepository truckRepository;
        private IDriverRepository driverRepository;
        public Menu()
        {
            var factoryProvider = new FactoryProvider(FactoryType.Txt);
            var factory = factoryProvider.GetRepositoryFactory();

            vehicleRepository = factory.GetVehicleRepository();
            truckRepository =  factory.GetTruckRepository();
            driverRepository = factory.GetDriverRepository();

        }
        public void ShowMenu()
        {
            Console.WriteLine("Welcome to Logistic Admin!");
            while (ShowMenuOnce()) { }
            Console.WriteLine("end");
        }

        private bool ShowMenuOnce()
        {
            Console.WriteLine("Select:\n1.-- Add new vehicle.\n2.-- Print All vehicles. \n3.-- Add new Truck. \n4.-- Print All trucks. \n5.-- Add new Driver. \n6.-- Print All Drivers.\n0.-- Exit");
            string userInput = Console.ReadLine();
            try
            {
                switch (userInput)
                {
                    case "1":
                        AddNewVehicle();
                        return true;
                    case "2":
                        PrintAllVehicles();
                        return true;
                    case "3":
                        AddNewTruck();
                        return true;
                    case "4":
                        PrintAllTrucks();
                        return true;
                    case "5":
                        AddNewDriver();
                        return true;
                    case "6":
                        PrintAllDrivers();
                        return true;
                    case "0":
                        return false;
                    default:
                        return true;
                }
            }catch(Exception ex)
            {
                Console.Error.WriteLine($"Error occured: " + ex.Message);
                return true;
            }
        }

        private void PrintAllDrivers()
        {
            var drivers = driverRepository.GetAll();
            for (int i = 0; i < driverRepository.Count(); i++)
            {
                Console.WriteLine(drivers[i]);
            }
        }

        private void AddNewDriver()
        {
            Console.WriteLine("Enter new Driver info: ");
            Console.Write("Id: ");
            var id = Console.ReadLine();
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Experience: ");
            var experience = Convert.ToInt32(Console.ReadLine());
            driverRepository.Add(new Driver
            {
                Name = name,
                Id = id,
                Experience = experience
            });
        }

        private void PrintAllTrucks()
        {
            var trucks = truckRepository.GetAll();
            for (int i = 0; i < truckRepository.Count(); i++)
            {
                Console.WriteLine(trucks[i]);
            }
        }

        private void AddNewTruck()
        {
            Console.WriteLine("Enter new Truck info:");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.WriteLine("Model: ");
            var model = Console.ReadLine();
            Console.Write("Year: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Capacity: ");
            var capacity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length: ");
            var length = Convert.ToInt32(Console.ReadLine());
            truckRepository.Add(new Truck
            {
                Name = name,
                Model = model,
                Year = year,
                Capacity = capacity,
                Length = length
            });
        }

        private void PrintAllVehicles()
        {
            var vehicles = vehicleRepository.GetAll();
            for(int i =0; i < vehicleRepository.Count(); i++)
            {
                Console.WriteLine(vehicles[i]);
            }
        }

        private void AddNewVehicle()
        {
            Console.WriteLine("Enter Vehicle info");
            Console.Write("Name: ");
            var name = Console.ReadLine();
            Console.Write("Model: ");
            var model = Console.ReadLine();
            Console.Write("Year: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Capacity: ");
            var capacity = Convert.ToInt32(Console.ReadLine());
            vehicleRepository.Add(new Vehicle
            {
                Name = name,
                Model = model,
                Year = year,
                Capacity = capacity
            });

        }
    }
}
