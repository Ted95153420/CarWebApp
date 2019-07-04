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
    [Route("api/vehicles/{vehicleId_}/pictures")]
    public class PicturesController : Controller {
        private readonly IVehicleRepository _vehicleRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<PicturesController> _logger;
        private readonly LinkGenerator _linkGenerator;

        public PicturesController(IVehicleRepository vehicleRepository_, 
                                IMapper mapper_, ILogger<PicturesController> logger_, LinkGenerator linkgenerator_)
        {
            _vehicleRepository = vehicleRepository_;
            _mapper = mapper_;
            _logger = logger_;
            _linkGenerator = linkgenerator_;
        }

        [HttpGet]
        public IActionResult GetPictures(int vehicleId_)
        {
           try{
               var pictures =  _vehicleRepository.GetVehiclePictures(vehicleId_);
               return Ok(_mapper.Map<IEnumerable<PictureViewModel>>(pictures));
           } 
           catch(Exception ex)
           {
              _logger.LogError($"Failed to retrieve pictures for vehicle : {ex}");
              return BadRequest("An Error Ocurred retrieving pictures for vehicle. Check Logs.");
           }
        }
    }
}