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

        public IEnumerable<VehicleModel> GetModelById(int vehicleMakeId_)
        {

            return from v in _vehicleContext.VehicleModels.ToList()
                                .Where(x=>x.VehicleMakeForeignKey==vehicleMakeId_) select v;
        }
    }
}