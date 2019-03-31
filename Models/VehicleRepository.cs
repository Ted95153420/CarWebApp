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
        public IEnumerable<VehicleMakes> GetAllMakes()
        {
            return _vehicleContext.VehicleMakes.ToList();
        }

        public IEnumerable<Dealer> GetDealerById(int dealerId_)
        {
            return from v in _vehicleContext.Dealer.ToList()
                                .Where(x => x.Id==dealerId_) select v;
        }

        public IEnumerable<VehicleModels> GetModelById(int vehicleMakeId_)
        {

            return from v in _vehicleContext.VehicleModels.ToList()
                                .Where(x=>x.VehicleMakeForeignKey==vehicleMakeId_) select v;
        }
    }
}