using Logistic.Domain.Convertors.txt;
using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;

namespace Logistic.Domain.Repositories.Concreate.Txt
{
    internal class TxtTruckRepository : TxtBaseRepository<Truck>, ITruckRepository
    {
        public TxtTruckRepository() : base("C:\\Users\\Lesia\\Desktop\\study\\practice\\Logistic\\Logistic.Domain\\Data\\txt\\trucks.txt", 
            new TruckTxtConvertor()) {
        }
    }
}
