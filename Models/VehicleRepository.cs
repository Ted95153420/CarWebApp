using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CarPriceComparison.Models
{
    public class VehicleRepository : IVehicleRepository
    {
        private VehicleContext _vehicleContext;
        public VehicleRepository(VehicleContext dbContext_)
        {
            _vehicleContext = dbContext_;
        }

        public void AddVehicle(Vehicle vehicle_)
        {
            _vehicleContext.Add(vehicle_);
        }

        public void AddPicture(Picture picture_)
        {
            _vehicleContext.Add(picture_);
        }

        public IEnumerable<VehicleMakes> GetAllMakes()
        {
            return _vehicleContext.VehicleMakes.ToList();
        }

        public IEnumerable<Picture> GetVehiclePictures(int vehicleId_)
        {
            return from v in _vehicleContext.Pictures.ToList()
                        .Where(x => x.Vehicle.Id == vehicleId_) select v;
        }

        public Picture GetIndividualPicture(int vehicleId_, int pictureId_)
        {
            IEnumerable<Picture> pictures =  from v in _vehicleContext.Pictures
                        .Include(vp => vp.Vehicle)
                        .Where(x => x.Vehicle.Id == vehicleId_
                                && x.Id == pictureId_) select v;    
            return pictures.FirstOrDefault();
        }

        public IEnumerable<Vehicle> GetAllVehicles()
        {
            return _vehicleContext.Vehicles.ToList();
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

        public Vehicle GetVehicleById(int vehicleId_)
        {
            IEnumerable<Vehicle> vehicles = from v in _vehicleContext.Vehicles.ToList()
                                .Where(x=>x.Id == vehicleId_) select v;
            return vehicles.FirstOrDefault();
        }

        public async Task<bool> SaveChangesAsync()
        {
            return (await _vehicleContext.SaveChangesAsync()) > 0;
        }
    }
}