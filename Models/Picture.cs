using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPriceComparison.Models
{
    public class Picture
    {
        public int Id {get; set;}
        public byte[] Image {get; set;}
        [ForeignKey("VehicleId")]
        public virtual Vehicle VehicleForeignKey{get;set;}
    }
}