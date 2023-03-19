using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;
using System;
using System.Security.AccessControl;

namespace Logistic.Domain.Repositories.Concreate
{
    internal class MonkVehicleRepository : IVehicleRepository
    {
        private Vehicle[] vehicles;
        int count;
        public MonkVehicleRepository()
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
