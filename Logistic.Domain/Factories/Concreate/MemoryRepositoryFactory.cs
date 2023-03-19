using Logistic.Domain.Factories.Abstract;
using Logistic.Domain.Repositories.Abstract;
using Logistic.Domain.Repositories.Concreate.Memory;

namespace Logistic.Domain.Factories.Concreate
{
    internal class MemoryRepositoryFactory : IRepositoriesFactory
    {
        public IVehicleRepository GetVehicleRepository() { return new MemoryVehicleRepository(); }
        public ITruckRepository GetTruckRepository() { return new MemoryTruckRepository(); }
        public IDriverRepository GetDriverRepository() { return new MemoryDriverRepository(); }
    }
}
