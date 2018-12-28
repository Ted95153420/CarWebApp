using System.Collections.Generic;

namespace CarPriceComparison.Models
{
    public class Country
    {
        public int Id {get; set;}
        public string CountryName {get; set;}
        public List<City> Cities{get; set;}
    }
}