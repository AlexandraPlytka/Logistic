using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;
using System;
using System.Security.AccessControl;

namespace Logistic.Domain.Repositories.Mock
{
    internal class MockVehicleRepository : IVehicleRepository
    {
        private Vehicle[] vehicles;
        int count;
        public MockVehicleRepository()
        {
            vehicles = new Vehicle[] {
                new Vehicle{Name="honda", Model= "msa", Year = 2003, Capacity = 300},
                new Vehicle{Name="mazda", Model= "m", Year = 2023, Capacity = 450},
                new Vehicle{Name="GMC", Model= "black", Year = 2020, Capacity = 100},
                new Vehicle{Name="tesla", Model= "x", Year = 2022, Capacity = 205},
            };
            count = 4;

        }
        public void Add(Vehicle vehicle)
        {
            //vehicles[count++] = vehicle;       
        }

        public int Count() => count;

        public Vehicle[] GetAll() => vehicles;

    }
}
