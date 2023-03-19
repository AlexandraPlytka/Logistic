using Logistic.Domain.Repositories.Abstract;


namespace Logistic.Domain.Factories.Abstract
{
    public interface IRepositoriesFactory
    {
        IVehicleRepository GetVehicleRepository();
        ITruckRepository GetTruckRepository();
        IDriverRepository GetDriverRepository();
    }

}
