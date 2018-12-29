using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPriceComparison.ViewModels
{
    public class VehicleViewModel
    {
        
        //Fuel Economy is in L/Km
        public float CityFuelEconomy {get;set;}
        public float HighwayFuelEconomy {get;set;}
        public float ListPrice {get;set;}
        public float SoldPrice{get;set;}
        [Required]
        public int MakeForeignKey {get;set;}
        [Required]
        public int ModelForeignKey {get;set;}
        [Required]
        public int DealerForeignKey{get;set;}
        public string Notes{get; set;}
        public string Color{get; set;}
    }
}