using Logistic.Domain.Convertors.txt;
using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;

namespace Logistic.Domain.Repositories.Concreate.Txt
{
    internal class TxtVehicleRepository : TxtBaseRepository<Vehicle>, IVehicleRepository
    {
        public TxtVehicleRepository() : base("C:\\Users\\Lesia\\Desktop\\study\\practice\\Logistic\\Logistic.Domain\\Data\\txt\\vehicles.txt", 
            new VehicleTxtConvertor()) { 
        }
    }
}
