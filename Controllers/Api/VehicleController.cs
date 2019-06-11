using Microsoft.AspNetCore.Mvc;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;

namespace CarPriceComparison.Controllers.Api{

    [Route("api/vehicles")]
    [ApiController]
    public class VehicleController : Controller    {
        private IMapper _mapper;
        private IVehicleRepository _vehicleRepository;
        private ILogger<VehicleController> _logger;
        private LinkGenerator _linkGenerator;

        public VehicleController(IVehicleRepository vehicleRepository_, 
                                    IMapper mapper_, 
                                    ILogger<VehicleController> logger_, LinkGenerator linkGenerator_)
        {
            _mapper = mapper_;
            _vehicleRepository = vehicleRepository_; 
            _logger = logger_;
            _linkGenerator = linkGenerator_; 
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
                _logger.LogError($"Failed to retrieve all vehicles : {ex}");
                return BadRequest("An Error Ocurred retrieving all vehicles. Check Logs.");
            }
        }

        [HttpGet("{id:int}")]
        public IActionResult GetVehicle(int vehicleId_)
        {
            try{

                var specificVehicle = _vehicleRepository.GetVehicleById(vehicleId_);

                if (specificVehicle == null) return NotFound();
                return Ok(_mapper.Map<VehicleViewModel>(specificVehicle));
            }
            catch(Exception ex)
            {
                _logger.LogError($"Failed to retrieve specific vehicle : {ex}");
                return BadRequest("An Error Ocurred retrieving a specific vehicle. Check Logs.");
            }
        }

        [HttpPost("")]
        public async Task<IActionResult> PostNewVehicleData(VehicleViewModel vehicleData_)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var newVehicle = _mapper.Map<Vehicle>(vehicleData_);
                    _vehicleRepository.AddVehicle(newVehicle);
                    if (await _vehicleRepository.SaveChangesAsync())
                    {
                        var vehicleModel = _mapper.Map<VehicleViewModel>(newVehicle);
                        var location = _linkGenerator.GetPathByAction("GetVehicle", "vehicles",
                                                                        new {id = newVehicle.Id});
                        return Created(location, _mapper.Map<VehicleViewModel>(newVehicle)); 
                    }
                } 
                return BadRequest("Failed to save the vehicle");
            }
            catch(Exception ex)
            {
                return BadRequest($"Exception Thrown :  {ex}");
            }
        }
    }
}