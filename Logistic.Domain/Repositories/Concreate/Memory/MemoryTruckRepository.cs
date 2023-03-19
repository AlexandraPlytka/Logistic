using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;

namespace Logistic.Domain.Repositories.Concreate.Memory
{
    internal class MemoryTruckRepository : ITruckRepository
    {
        private Truck[] trucks;
        int count;
        public MemoryTruckRepository()
        {
            trucks= new Truck[100];
            count = 0; 
        }
        public void Add(Truck truck)
        {
            trucks[count++] = truck;       
        }

        public int Count() => count;

        public Truck[] GetAll() => trucks;
    }
}
