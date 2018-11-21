using System.Collections.Generic;

namespace CarPriceComparison.Models
{
    public class VehicleMake
    {
        public int Id {get; set;}
        public string Make {get; set;}
        public List<VehicleModel>   Models{get; set;}
    }
}