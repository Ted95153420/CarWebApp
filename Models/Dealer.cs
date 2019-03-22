using System.Collections.Generic;

namespace CarPriceComparison.Models
{
    public class Dealer
    {
        public Dealer()
        {
            
        }
        public int Id {get; set;}
        public string DealerName {get; set;}
        public string StreetAddress{get; set;}
        public City City{get;set;}
        public string PostalCode{get;set;}
        public string WebAddress{get;set;}
        public string PhoneNumber{get;set;}
        public List<Vehicle> Vehicles{get;set;}
        public int CityForeignKey{get; set;}

    }
}