using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarPriceComparison.Models
{
    public class Vehicle
    {
        [Key]
        public int SourceId {get; set;}
        public int Id {get; set;}
        
        //Fuel Economy is in L/Km
        public float CityFuelEconomy {get;set;}
        public float HighwayFuelEconomy {get;set;}
        public float ListPrice {get;set;}
        public float SoldPrice{get;set;}
        [ForeignKey("VehicleMakeId")]
        public virtual VehicleMakes MakeForeignKey {get;set;}
        [ForeignKey("VehicleModelId")]
        public virtual VehicleModels ModelForeignKey {get;set;}
        [ForeignKey("VehicleDealerId")]
        public virtual Dealer DealerForeignKey{get;set;}
        public string Notes{get; set;}
        public string Color{get; set;}
    }
}