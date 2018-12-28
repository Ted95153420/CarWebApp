using System.Collections.Generic;

namespace CarPriceComparison.Models
{
    public class City
    {
        public int Id {get; set;}
        public string CityName {get; set;}
        public Country Country{get; set;}

        public List<Dealer> Dealerships{get; set;}
        public int CountryForeignKey{get; set;}

    }
}