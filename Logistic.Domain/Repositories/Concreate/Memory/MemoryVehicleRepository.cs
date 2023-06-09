﻿using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;

namespace Logistic.Domain.Repositories.Concreate.Memory
{
    internal class MemoryVehicleRepository : IVehicleRepository
    {
        private Vehicle[] vehicles;
        int count;
        public MemoryVehicleRepository()
        {
            vehicles = new Vehicle[100];
            count = 0;

        }
        public void Add(Vehicle vehicle)
        {
            vehicles[count++] = vehicle;       
        }

        public int Count() => count;

        public Vehicle[] GetAll() => vehicles;

    }
}
