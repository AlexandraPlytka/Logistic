using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;
using System;

namespace Logistic.Domain.Repositories.Mock
{
    internal class MockTruckRepository : ITruckRepository
    {
        private Truck[] trucks;
        int count;
        public MockTruckRepository()
        {
            trucks = new Truck[] { 
                new Truck{Name = "Truck1", Model = "m1", Year = 2016, Capacity =700, Length = 150},
                new Truck{Name = "Truck2", Model = "m2", Year = 2006, Capacity =600, Length = 100},
                new Truck{Name = "Truc3", Model = "vs", Year = 2020, Capacity =950, Length = 300},
                new Truck{Name = "Tr4", Model = "MAE", Year = 2022, Capacity =900, Length = 270},

            };
            count = 4; 
        }
        public void Add(Truck truck)
        {
           // trucks[count++] = truck;       
        }

        public int Count() => count;

        public Truck[] GetAll() => trucks;
    }
}
