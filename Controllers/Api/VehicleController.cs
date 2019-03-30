using Microsoft.AspNetCore.Mvc;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;
using AutoMapper;
using System;

namespace CarPriceComparison.Controllers.Api{

    [Route("api/vehicles")]
    public class VehicleController : Controller    {
        private IMapper _mapper;
        private IVehicleRepository _vehicleRepository;
        public VehicleController(IVehicleRepository vehicleRepository_, IMapper mapper_)
        {
            _mapper = mapper_;
            _vehicleRepository = vehicleRepository_;  
        }
        [HttpGet("")]
        public IActionResult GetVehicleMakes()
        {
            try{
                return Ok(_vehicleRepository.GetAllMakes());
            }
            catch(Exception ex)
            {
                //TODO - add logging
                return BadRequest("An Error Ocurred");
            }
        }

        [HttpPost("")]
        public IActionResult PostNewVehicleData([FromBody]VehicleViewModel vehicleData_)
        {
            if (ModelState.IsValid)
            {
                //ultimately we want our new vehicle data saving to the database....
                var newVehicle = _mapper.Map<Vehicle>(vehicleData_);
                //mapper mapping from model to ViewMOdel so no actual model data send back.
                return Created($"api/Vehicles/{vehicleData_.Notes}", Mapper.Map<VehicleViewModel>(vehicleData_)); 
            } 

            return BadRequest("Bad Data");
        }
    }
}