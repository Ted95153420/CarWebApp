using Microsoft.AspNetCore.Mvc;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;

namespace CarPriceComparison.Controllers.Api{

    [Route("api/vehicles")]
    public class VehicleController : Controller    {
        private IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicleRepository_)
        {
            _vehicleRepository = vehicleRepository_;  
        }
        [HttpGet("")]
        public IActionResult GetVehicleMakes()
        {
            return Ok(_vehicleRepository.GetAllMakes());
        }

        [HttpPost("")]
        public IActionResult PostNewVehicleData([FromBody]VehicleViewModel vehicleData_)
        {
            if (ModelState.IsValid)
            {
                //ultimately we want our new vehicle data saving to the database....
                return Ok(true); 
            } 

            return BadRequest("Bad Data");
        }
    }
}