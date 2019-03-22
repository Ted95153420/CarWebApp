using System.Collections.Generic;

namespace CarPriceComparison.Models
{
    public interface IVehicleRepository
    {
        IEnumerable<VehicleMakes> GetAllMakes();

        IEnumerable<VehicleModels> GetModelById(int id_);

        IEnumerable<Dealer> GetDealerById(int id_);
    }
}