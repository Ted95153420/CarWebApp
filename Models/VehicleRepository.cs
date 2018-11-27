using System.Collections.Generic;
using System.Linq;

namespace CarPriceComparison.Models
{
    public class VehicleRepository : IVehicleRepository
    {
        private VehicleContext _vehicleContext;
        public VehicleRepository(VehicleContext dbContext_)
        {
            _vehicleContext = dbContext_;
        }
        public IEnumerable<VehicleMake> GetAllMakes()
        {
            return _vehicleContext.VehicleMakes.ToList();
        }
    }
}