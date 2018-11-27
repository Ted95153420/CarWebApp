using System.Collections.Generic;

namespace CarPriceComparison.Models
{
    public interface IVehicleRepository
    {
        IEnumerable<VehicleMake> GetAllMakes();
    }
}