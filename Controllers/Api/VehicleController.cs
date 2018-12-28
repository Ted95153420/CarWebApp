using Microsoft.AspNetCore.Mvc;
using CarPriceComparison.Models;

namespace CarPriceComparison.Controllers.Api{
    public class VehicleController : Controller    {
        private IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicleRepository_)
        {
            _vehicleRepository = vehicleRepository_;  
        }
        [HttpGet("api/vehicles")]
        public IActionResult Get()
        {
            return Ok(_vehicleRepository.GetAllMakes());
        }
    }
}