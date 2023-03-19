using Logistic.Domain.Enums;
using Logistic.Domain.Factories;
using Logistic.Domain.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic.User.UI
{
    internal class Menu
    {
        private IVehicleRepository vehicleRepository;
        private ITruckRepository truckRepository;
        private IDriverRepository driverRepository;
        public Menu()
        {
            var factoryProvider = new FactoryProvider(FactoryType.Mock);
            var factory = factoryProvider.GetRepositoryFactory();

            vehicleRepository = factory.GetVehicleRepository();
            truckRepository = factory.GetTruckRepository();
            driverRepository = factory.GetDriverRepository();

        }

        public void ShowMenu()
        {
            Console.WriteLine("Welcome to Logistic User!");
            while (ShowMenuOnce()) { }
            Console.WriteLine("end");
        }
        private bool ShowMenuOnce()
        {
            Console.WriteLine("Select:\n1.-- Print All vehicles. \n2.-- Print All trucks. \n3.-- Print All Drivers.\n0.-- Exit");
            string userInput = Console.ReadLine();
            try
            {
                switch (userInput)
                {
                    case "1":
                        PrintAllVehicles();
                        return true;
                    case "2":
                        PrintAllTrucks();
                        return true;
                    case "3":
                        PrintAllDrivers();
                        return true;
                    case "0":
                        return false;
                    default:
                        return true;
                }
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine($"Error occured: " +ex.Message);
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

        private void PrintAllTrucks()
        {
            var trucks = truckRepository.GetAll();
            for (int i = 0; i < truckRepository.Count(); i++)
            {
                Console.WriteLine(trucks[i]);
            }
        }

        private void PrintAllVehicles()
        {
            var vehicles = vehicleRepository.GetAll();
            for (int i = 0; i < vehicleRepository.Count(); i++)
            {
                Console.WriteLine(vehicles[i]);
            }
        }
    }
}
