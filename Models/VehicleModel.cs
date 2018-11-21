namespace CarPriceComparison.Models
{
    public class VehicleModel
    {
        public int Id {get; set;}
        public string Model {get; set;}
        public VehicleMake Make {get; set;}
        public int VehicleMakeForeignKey{get; set;}
    }
}