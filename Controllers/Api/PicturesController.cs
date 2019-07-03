using Microsoft.AspNetCore.Mvc;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Routing;
using Microsoft.AspNetCore.Http;

namespace CarPriceComparison.Controllers.Api{
    [ApiController]
    [Route("api/vehicles{{vehicleId_}/pictures")]
    public class PicturesController : Controller {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;
        private readonly LinkGenerator _linkGenerator;

        public PicturesController(IVehicleRepository vehicleRepository_, 
                                IMapper mapper_, LinkGenerator linkgenerator_)
        {
            _vehicleRepository = vehicleRepository_;
            _mapper = mapper_;
            _linkGenerator = linkgenerator_;
        }

        [HttpGet]
        public async Task<ActionResult<Picture[]>> Get(int vehicleId_)
        {
           try{
               var pictures = await _vehicleRepository.GetVehiclePicturesAsync();
               return pictures;
           } 
           catch(Exception)
           {
               return StatusCode(StatusCodes.Status500InternalServerError("Failed to get vehicle pictures"))
           }
        }
    }
}