using Logistic.Domain.Factories.Abstract;
using Logistic.Domain.Repositories.Abstract;
using Logistic.Domain.Repositories.Concreate.Mock;

namespace Logistic.Domain.Factories.Mock
{
    internal class MockRepositoryFactory : IRepositoriesFactory
    {

        public IVehicleRepository GetVehicleRepository() { return new MockVehicleRepository(); }
        public ITruckRepository GetTruckRepository() { return new MockTruckRepository(); }
        public IDriverRepository GetDriverRepository() { return new MockDriverRepository(); }
    }
}
