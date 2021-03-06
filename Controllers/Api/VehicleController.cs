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

        [HttpGet("{vehicleId_:int}")]
        public IActionResult GetVehicle(int vehicleId_)
        {
            try{

                var specificVehicle = _vehicleRepository.GetVehicleById(vehicleId_);

                if (specificVehicle == null) return NotFound();
                var vehicleViewModel = _mapper.Map<VehicleViewModel>(specificVehicle);
                //TODO - why are DealerForeignKey and MOdelForeignKey returned as null
                //but have a value in the database??
                //vehicleViewModel.DealerForeignKey = specificVehicle.DealerForeignKey.Id;
                //vehicleViewModel.ModelForeignKey = specificVehicle.ModelForeignKey.Id;
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
                    var location = _linkGenerator.GetPathByAction("GetVehicle", "Vehicle",
                                                                        new {vehicleId_ = newVehicle.Id});
                    
                    if (string.IsNullOrWhiteSpace(location))
                    {
                        return BadRequest("could not use vehicleId_ to create a new vehicle in the database");
                    }
                    if (await _vehicleRepository.SaveChangesAsync())
                    {
                        //TODO - hate the way GetPathByAction is called twice. Second call gets a valid Id
                        //AFTER the record is added to the database. Anyway round this??
                        location = _linkGenerator.GetPathByAction("GetVehicle", "Vehicle",
                                                                        new {vehicleId_ = newVehicle.Id});
                        var vehicleViewModel = _mapper.Map<VehicleViewModel>(newVehicle);
                        vehicleViewModel.ModelForeignKey = newVehicle.ModelForeignKey.Id;
                        vehicleViewModel.DealerForeignKey = newVehicle.DealerForeignKey.Id;
                        return Created(location, vehicleViewModel); 
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