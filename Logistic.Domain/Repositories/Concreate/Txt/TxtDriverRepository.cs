using Logistic.Domain.Convertors.txt;
using Logistic.Domain.Models;
using Logistic.Domain.Repositories.Abstract;

namespace Logistic.Domain.Repositories.Concreate.Txt
{
    internal class TxtDriverRepository : TxtBaseRepository<Driver>, IDriverRepository
    {
        public TxtDriverRepository() : base("C:\\Users\\Lesia\\Desktop\\study\\practice\\Logistic\\Logistic.Domain\\Data\\txt\\drivers.txt", 
            new DriverTxtConvertor()) { 

        
        }
        
    }
}
