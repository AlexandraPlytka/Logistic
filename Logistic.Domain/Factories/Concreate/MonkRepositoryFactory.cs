using Logistic.Domain.Factories.Abstract;
using Logistic.Domain.Repositories.Abstract;
using Logistic.Domain.Repositories.Concreate;
using Logistic.Domain.Repositories.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistic.Domain.Factories.Mock
{
    internal class MockRepositoryFactory : IRepositoriesFactory
    {

        public IVehicleRepository GetVehicleRepository() { return new MockVehicleRepository(); }
        public ITruckRepository GetTruckRepository() { return new MockTruckRepository(); }
        public IDriverRepository GetDriverRepository() { return new MockDriverRepository(); }
    }
}
