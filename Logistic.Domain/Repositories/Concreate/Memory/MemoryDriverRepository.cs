using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;

namespace Logistic.Domain.Repositories.Concreate.Memory
{
    public class MemoryDriverRepository : IDriverRepository
    {
        private Driver[] drivers;
        int count;
        public MemoryDriverRepository()
        {
            drivers= new Driver[100];
            count = 0;
        }
        public void Add(Driver driver)
        {
            drivers[count++] = driver;
        }

        public int Count() => count;

        public Driver[] GetAll() => drivers;
        
    }
}
