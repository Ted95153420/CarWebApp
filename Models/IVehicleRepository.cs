using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarPriceComparison.Models
{
    public interface IVehicleRepository
    {
        IEnumerable<VehicleMakes> GetAllMakes();

        IEnumerable<VehicleModels> GetModelById(int id_);

        IEnumerable<Dealer> GetDealerById(int id_);
        IEnumerable<Vehicle> GetAllVehicles();

        Vehicle GetVehicleById(int id_);

        void AddVehicle(Vehicle vehicle_);

        Task <bool> SaveChangesAsync();

        IEnumerable<Picture> GetVehiclePicturesAsync(int vehicleId_);
    }
}