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

        [HttpGet("{pictureId_:int}")]
        public IActionResult GetIndividualPicture(int vehicleId_, int pictureId_)
        {
            try{
                var picture =  _vehicleRepository.GetIndividualPicture(vehicleId_, pictureId_);
                return Ok(_mapper.Map<PictureViewModel>(picture));
            }
            catch(Exception ex)
            {
                _logger.LogError($"Failed to retrieve specific picture : {ex}");
                return BadRequest("An Error Ocurred retrieving an individual picture. Check Logs.");    
            }
        }

        [HttpPost]
        public async Task<IActionResult> PostNewPicture(int vehicleId_, PictureViewModel picture_)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var vehicle = _vehicleRepository.GetVehicleById(vehicleId_);
                    if (vehicle == null) return BadRequest("Vehicle Not Found");

                    var newPicture = _mapper.Map<Picture>(picture_);
                    newPicture.Vehicle = vehicle;
                    _vehicleRepository.AddPicture(newPicture);
                    if (await _vehicleRepository.SaveChangesAsync())
                    {
                        var url = _linkGenerator.GetPathByAction("GetIndividualPicture", 
                                                                "Pictures",
                                                                new {vehicleId_ = newPicture.Vehicle.Id,
                                                                     pictureId_ = newPicture.Id});
                        var pictureViewModel = _mapper.Map<PictureViewModel>(newPicture);
                        return Created(url, _mapper.Map<PictureViewModel>(newPicture)); 
                    }
                }
                return BadRequest("Failed to save the picture");
            }
            catch(Exception ex)
            {
                return BadRequest($"Exception Thrown :  {ex}");
            }
        }
    }
}