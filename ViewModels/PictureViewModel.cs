using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPriceComparison.ViewModels
{
    public class PictureViewModel
    {
        //Fuel Economy is in L/Km
        public byte[] Image {get; set;}

        [Required]
        public int VehicleForeignKey{get;set;}
    }
}