using System.Collections.Generic;

namespace CarPriceComparison.Models
{
    public class VehicleMakes
    {
        public int Id {get; set;}
        public string Make {get; set;}
        public List<VehicleModels>   Models{get; set;}
    }
}