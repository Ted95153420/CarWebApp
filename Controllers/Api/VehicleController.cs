using Microsoft.AspNetCore.Mvc;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CarPriceComparison.Controllers.Api{

    [Route("api/vehicles")]
    public class VehicleController : Controller    {
        private IMapper _mapper;
        private IVehicleRepository _vehicleRepository;
        private ILogger<VehicleController> _logger;

        public VehicleController(IVehicleRepository vehicleRepository_, IMapper mapper_, ILogger<VehicleController> logger_)
        {
            _mapper = mapper_;
            _vehicleRepository = vehicleRepository_; 
            _logger = logger_; 
        }
        [HttpGet("")]
        public IActionResult GetAllVehicles()
        {
            try{

                var allVehicles = _vehicleRepository.GetAllVehicles();

                return Ok(_mapper.Map<IEnumerable<VehicleViewModel>>(allVehicles));
            }
            catch(Exception ex)
            {
                _logger.LogError($"Failed to rettrieve all vehicles : {ex}");
                return BadRequest("An Error Ocurred");
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> PostNewVehicleData([FromBody]VehicleViewModel vehicleData_)
        {
            if (ModelState.IsValid)
            {
                
                var newVehicle = _mapper.Map<Vehicle>(vehicleData_);
                if (await _vehicleRepository.SaveChangesAsync())
                {
                    return Created($"api/Vehicles/{vehicleData_.Notes}", _mapper.Map<VehicleViewModel>(newVehicle)); 
                }
            } 

            return BadRequest("Failed to save the vehicle");
        }
    }
}