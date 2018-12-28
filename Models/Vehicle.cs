using System.Collections.Generic;

namespace CarPriceComparison.Models
{
    public class Vehicle
    {
        public int Id {get; set;}
        
        //Fuel Economy is in L/Km
        public float CityFuelEconomy {get;set;}
        public float HighwayFuelEconomy {get;set;}
        public float ListPrice {get;set;}
        public float SoldPrice{get;set;}
        public VehicleMake VehicleMake{get; set;}
        public int MakeForeignKey {get;set;}
        public VehicleModel VehicleModel{get;set;}
        public int ModelForeignKey {get; set;}
        public Dealer Dealer {get; set;}
        public int DealerForeignKey {get;set;}
        public string Notes{get; set;}
        public string Color{get; set;}
    }
}