using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPriceComparison.ViewModels
{
    public class PictureViewModel
    {
        //the image is saved in the Db as a base64 encoded string
        public string Image {get; set;}

        [Required]
        public int VehicleForeignKey{get;set;}
    }
}