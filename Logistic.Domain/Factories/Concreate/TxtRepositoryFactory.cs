using Logistic.Domain.Factories.Abstract;
using Logistic.Domain.Repositories.Abstract;
using Logistic.Domain.Repositories.Concreate.Txt;

namespace Logistic.Domain.Factories.Concreate
{
    internal class TxtRepositoryFactory : IRepositoriesFactory
    {
        public IVehicleRepository GetVehicleRepository() { return new TxtVehicleRepository(); }
        public ITruckRepository GetTruckRepository() { return new TxtTruckRepository(); }
        public IDriverRepository GetDriverRepository() { return new TxtDriverRepository(); }
    }
}
