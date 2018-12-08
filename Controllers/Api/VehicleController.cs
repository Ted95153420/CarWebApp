using Microsoft.AspNetCore.Mvc;
using CarPriceComparison.Models;

namespace CarPriceComparison.Controllers.Api{
    public class VehicleController : Controller
    {
        [HttpGet("api/vehicles")]
        public IActionResult Get()
        {
            return Ok(new VehicleMake(){Id=600, Make="Blah"});
        }
    }
}