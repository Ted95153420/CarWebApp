namespace CarPriceComparison.Models
{
    public class VehicleModels
    {
        public int Id {get; set;}
        public string Model {get; set;}
        public VehicleMakes Make {get; set;}
        public int VehicleMakeForeignKey{get; set;}
    }
}