using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPriceComparison.Models
{
    public class Picture
    {
        public int Id {get; set;}
        public string Image {get; set;}
        [ForeignKey("VehicleId")]
        public virtual Vehicle Vehicle{get;set;}
    }
}