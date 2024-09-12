using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.IO;
using System.Reflection.Emit;

namespace CarPriceComparison.Models
{
    public class VehicleContext : DbContext
    {
        private IConfigurationRoot _config;
        public VehicleContext(IConfigurationRoot config_, DbContextOptions options_) : base(options_)
        {
            _config = config_;    
        }

        private void SeedData(ModelBuilder modelBuilder_)
        {
            // Seed Country data
            modelBuilder_.Entity<Country>().HasData(
                new Country { Id = 1, CountryName = "Canada" }

            );

            //Seed City data - add the 100 largest Canadian Cities
            modelBuilder_.Entity<City>().HasData(
               new City { Id = 1, CityName = "Toronto" ,CountryForeignKey = 1},
               new City { Id = 2, CityName = "Montréal", CountryForeignKey = 1 },
               new City { Id = 3, CityName = "Vancouver", CountryForeignKey = 1 },
               new City { Id = 4, CityName = "Calgary", CountryForeignKey = 1 },
               new City { Id = 5, CityName = "Ottowa", CountryForeignKey = 1 },
               new City { Id = 6, CityName = "Edmonton", CountryForeignKey = 1 },
               new City { Id = 7, CityName = "Mississauga", CountryForeignKey = 1 },
               new City { Id = 8, CityName = "North York", CountryForeignKey = 1 },
               new City { Id = 9, CityName = "Winnipeg", CountryForeignKey = 1 },
               new City { Id = 10, CityName = "Québec City", CountryForeignKey = 1 },
               new City { Id = 11, CityName = "Hamilton", CountryForeignKey = 1 },
               new City { Id = 12, CityName = "Brampton", CountryForeignKey = 1 },
               new City { Id = 13, CityName = "Kitchener", CountryForeignKey = 1 },
               new City { Id = 14, CityName = "Surrey", CountryForeignKey = 1 },
               new City { Id = 15, CityName = "Laval", CountryForeignKey = 1 },
               new City { Id = 16, CityName = "Halifax", CountryForeignKey = 1 },
               new City { Id = 17, CityName = "London", CountryForeignKey = 1 },
               new City { Id = 18, CityName = "Victoria", CountryForeignKey = 1 },
               new City { Id = 19, CityName = "Windsor", CountryForeignKey = 1 },
               new City { Id = 20, CityName = "Oshowa", CountryForeignKey = 1 },
               new City { Id = 21, CityName = "Gatineau", CountryForeignKey = 1 },
               new City { Id = 22, CityName = "Vaughan", CountryForeignKey = 1 },
               new City { Id = 23, CityName = "Longueuil", CountryForeignKey = 1 },
               new City { Id = 24, CityName = "Burnaby", CountryForeignKey = 1 },
               new City { Id = 25, CityName = "Ladner", CountryForeignKey = 1 },
               new City { Id = 26, CityName = "Saskatoon", CountryForeignKey = 1 },
               new City { Id = 27, CityName = "Barrie", CountryForeignKey = 1 },
               new City { Id = 28, CityName = "Richmond", CountryForeignKey = 1 },
               new City { Id = 29, CityName = "Regina", CountryForeignKey = 1 },
               new City { Id = 30, CityName = "Oakville", CountryForeignKey = 1 },
               new City { Id = 31, CityName = "Burlington", CountryForeignKey = 1 },
               new City { Id = 32, CityName = "Greater Sudbury", CountryForeignKey = 1 },
               new City { Id = 33, CityName = "Abbotsford", CountryForeignKey = 1 },
               new City { Id = 34, CityName = "Saguenay", CountryForeignKey = 1 },
               new City { Id = 35, CityName = "St Catherines", CountryForeignKey = 1 },
               new City { Id = 36, CityName = "Sherbrooke", CountryForeignKey = 1 },
               new City { Id = 37, CityName = "Lévis", CountryForeignKey = 1 },
               new City { Id = 38, CityName = "Kelowna", CountryForeignKey = 1 },
               new City { Id = 39, CityName = "Cambridge", CountryForeignKey = 1 },
               new City { Id = 40, CityName = "Trois Rivières", CountryForeignKey = 1 },
               new City { Id = 41, CityName = "Guelph", CountryForeignKey = 1 },
               new City { Id = 42, CityName = "Coquitlam", CountryForeignKey = 1 },
               new City { Id = 43, CityName = "Kingston", CountryForeignKey = 1 },
               new City { Id = 44, CityName = "Chatham-Kent", CountryForeignKey = 1 },
               new City { Id = 45, CityName = "Sydney", CountryForeignKey = 1 },
               new City { Id = 46, CityName = "Delta", CountryForeignKey = 1 },
               new City { Id = 47, CityName = "DartMouth", CountryForeignKey = 1 },
               new City { Id = 48, CityName = "Thunder Bay", CountryForeignKey = 1 },
               new City { Id = 49, CityName = "St John's", CountryForeignKey = 1 },
               new City { Id = 50, CityName = "Waterloo", CountryForeignKey = 1 },
               new City { Id = 51, CityName = "Terrebonne", CountryForeignKey = 1 },
               new City { Id = 52, CityName = "Langley", CountryForeignKey = 1 },
               new City { Id = 53, CityName = "Saint John", CountryForeignKey = 1 },
               new City { Id = 54, CityName = "Pickering", CountryForeignKey = 1 },
               new City { Id = 55, CityName = "Brantford", CountryForeignKey = 1 },
               new City { Id = 56, CityName = "Moncton", CountryForeignKey = 1 },
               new City { Id = 57, CityName = "Nanaimo", CountryForeignKey = 1 },
               new City { Id = 58, CityName = "Sarnia", CountryForeignKey = 1 },
               new City { Id = 59, CityName = "Niagra Falls", CountryForeignKey = 1 },
               new City { Id = 60, CityName = "Saint-Laurent", CountryForeignKey = 1 },
               new City { Id = 61, CityName = "Repentigny", CountryForeignKey = 1 },
               new City { Id = 62, CityName = "Fort McMurray", CountryForeignKey = 1 },
               new City { Id = 63, CityName = "Peterborough", CountryForeignKey = 1 },
               new City { Id = 64, CityName = "Sault Ste. Marie", CountryForeignKey = 1 },
               new City { Id = 65, CityName = "Kawartha Lakes", CountryForeignKey = 1 },
               new City { Id = 66, CityName = "Red Deer", CountryForeignKey = 1 },
               new City { Id = 67, CityName = "Saint-Jean-sur-Richelieu", CountryForeignKey = 1 },
               new City { Id = 68, CityName = "Lethbridge", CountryForeignKey = 1 },
               new City { Id = 69, CityName = "Maple Ridge", CountryForeignKey = 1 },
               new City { Id = 70, CityName = "Brossard", CountryForeignKey = 1 },
               new City { Id = 71, CityName = "Chilliwack", CountryForeignKey = 1 },
               new City { Id = 72, CityName = "Kamloops", CountryForeignKey = 1 },
               new City { Id = 73, CityName = "White Rock", CountryForeignKey = 1 },
               new City { Id = 74, CityName = "Prince George", CountryForeignKey = 1 },
               new City { Id = 75, CityName = "Medicine Hat", CountryForeignKey = 1 },
               new City { Id = 76, CityName = "Norfolk County", CountryForeignKey = 1 },
               new City { Id = 77, CityName = "Drummondville", CountryForeignKey = 1 },
               new City { Id = 78, CityName = "New Westminster", CountryForeignKey = 1 },
               new City { Id = 79, CityName = "St Albert", CountryForeignKey = 1 },
               new City { Id = 80, CityName = "Sherwood Park", CountryForeignKey = 1 },
               new City { Id = 81, CityName = "Saint-Jérôme", CountryForeignKey = 1 },
               new City { Id = 82, CityName = "Jonquière", CountryForeignKey = 1 },
               new City { Id = 83, CityName = "Granby", CountryForeignKey = 1 },
               new City { Id = 84, CityName = "Fredericton", CountryForeignKey = 1 },
               new City { Id = 85, CityName = "Welland", CountryForeignKey = 1 },
               new City { Id = 86, CityName = "Saint-Hyacinthe", CountryForeignKey = 1 },
               new City { Id = 87, CityName = "North Bay", CountryForeignKey = 1 },
               new City { Id = 88, CityName = "Shawinigan", CountryForeignKey = 1 },
               new City { Id = 89, CityName = "Dollard-Des Ormeaux", CountryForeignKey = 1 },
               new City { Id = 90, CityName = "Belleville", CountryForeignKey = 1 },
               new City { Id = 91, CityName = "Cornwall", CountryForeignKey = 1 },
               new City { Id = 92, CityName = "North Vancouver", CountryForeignKey = 1 },
               new City { Id = 93, CityName = "Vernon", CountryForeignKey = 1 },
               new City { Id = 94, CityName = "Blainville", CountryForeignKey = 1 },
               new City { Id = 95, CityName = "Haldimand County", CountryForeignKey = 1 },
               new City { Id = 96, CityName = "Timmins", CountryForeignKey = 1 },
               new City { Id = 97, CityName = "Châteauguay", CountryForeignKey = 1 },
               new City { Id = 98, CityName =  "Quinte West", CountryForeignKey = 1 },
               new City { Id = 99, CityName = "Charlottetown", CountryForeignKey = 1 },
               new City { Id = 100, CityName = "Rimouski", CountryForeignKey = 1 }
           );

            // Seed Dealer data - just for the City of Kamloops
            modelBuilder_.Entity<Dealer>().HasData(
                new Dealer { Id = 1, DealerName="Kamloops Kia",  StreetAddress = "880 8th St", PostalCode = "V2B 2X5", PhoneNumber="250-376-7266", WebAddress = "https://www.kamloopskia.com/", CityForeignKey = 72 },
                new Dealer { Id = 2, DealerName = "Sun Country Toyota", StreetAddress = "1355 Cariboo Pl, Kamloops, British Columbia", PostalCode = "V2C 5Z3", PhoneNumber = "250-828-7966", WebAddress = "https://www.suncountrytoyota.ca/", CityForeignKey = 72 }

            );

            // Seed Car Make Data
            modelBuilder_.Entity<VehicleMakes>().HasData(
                new VehicleMakes { Id = 1, Make = "Toyota" },
                new VehicleMakes { Id = 2, Make = "Ford" },
                new VehicleMakes { Id = 3, Make = "Chevrolet" },
                new VehicleMakes { Id = 4, Make = "Honda" },
                new VehicleMakes { Id = 5, Make = "Nissan" },
                new VehicleMakes { Id = 6, Make = "Jeep" },
                new VehicleMakes { Id = 7, Make = "Hyundai" },
                new VehicleMakes { Id = 8, Make = "Kia" },
                new VehicleMakes { Id = 9, Make = "Ram" },
                new VehicleMakes { Id = 10, Make = "Subaru" },
                new VehicleMakes { Id = 11, Make = "GMC" },
                new VehicleMakes { Id = 12, Make = "Volkswagen" },
                new VehicleMakes { Id = 13, Make = "BMW" },
                new VehicleMakes { Id = 14, Make = "Mazda" },
                new VehicleMakes { Id = 15, Make = "Mercedes-Benz" },
                new VehicleMakes { Id = 16, Make = "Lexus" },
                new VehicleMakes { Id = 17, Make = "Tesla" },
                new VehicleMakes { Id = 18, Make = "Dodge" },
                new VehicleMakes { Id = 19, Make = "Audi" },
                new VehicleMakes { Id = 20, Make = "Buik" },
                new VehicleMakes { Id = 21, Make = "Acura" },
                new VehicleMakes { Id = 22, Make = "Volvo" },
                new VehicleMakes { Id = 23, Make = "Cadillac" },
                new VehicleMakes { Id = 24, Make = "Chrysler" },
                new VehicleMakes { Id = 25, Make = "Mitsubishi" },
                new VehicleMakes { Id = 26, Make = "Land Rover" },
                new VehicleMakes { Id = 27, Make = "Lincoln" },
                new VehicleMakes { Id = 28, Make = "Porsche" },
                new VehicleMakes { Id = 29, Make = "Infiniti" },
                new VehicleMakes { Id = 30, Make = "Genesis" },
                new VehicleMakes { Id = 31, Make = "Mini" },
                new VehicleMakes { Id = 32, Make = "Maserati" },
                new VehicleMakes { Id = 33, Make = "Alfa Romeo" },
                new VehicleMakes { Id = 34, Make = "Jaguar" },
                new VehicleMakes { Id = 35, Make = "Bentley" },
                new VehicleMakes { Id = 36, Make = "Ferrari" },
                new VehicleMakes { Id = 37, Make = "Lamborghini" },
                new VehicleMakes { Id = 38, Make = "Aston Martin" },
                new VehicleMakes { Id = 39, Make = "Polestar" },
                new VehicleMakes { Id = 40, Make = "Fiat" },
                new VehicleMakes { Id = 41, Make = "Rolls-Royce" },
                new VehicleMakes { Id = 42, Make = "McLaren" },
                new VehicleMakes { Id = 43, Make = "Lucid" },
                new VehicleMakes { Id = 44, Make = "Bugatti" },
                new VehicleMakes { Id = 45, Make = "Rivian" },
                new VehicleMakes { Id = 46, Make = "Canoo" },
                new VehicleMakes { Id = 47, Make = "Pontiac" },
                new VehicleMakes { Id = 48, Make = "Oldsmobile" },
                new VehicleMakes { Id = 49, Make = "Rimac" }
            );

            //Seed Model data - just for Toyota and Ford
            modelBuilder_.Entity<VehicleModels>().HasData(
                new VehicleModels { Id = 1, Model = "GR86", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 2, Model = "GR Corolla", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 3, Model = "GR Supra", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 4, Model = "Prius", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 5, Model = "Pruis Prime", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 6, Model = "Corolla Hatchback", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 7, Model = "Corolla", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 8, Model = "Camry", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 9, Model = "Mirai", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 10, Model = "Crown", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 11, Model = "bZ4X", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 12, Model = "Corolla Cross", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 13, Model = "RAV4", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 14, Model = "RAV4 Prime", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 15, Model = "Venza", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 16, Model = "Crown Signia", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 17, Model = "Highlander", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 18, Model = "Grand Highlander", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 19, Model = "Sienna", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 20, Model = "4Runner", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 21, Model = "Land Cruiser", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 22, Model = "Sequoia", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 23, Model = "Tacoma", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 24, Model = "Tundra", VehicleMakeForeignKey = 1 },
                new VehicleModels { Id = 25, Model = "Mustang", VehicleMakeForeignKey = 2},
                new VehicleModels { Id = 26, Model = "GT", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 27, Model = "Ranger", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 28, Model = "Maverick", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 29, Model = "F-150", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 30, Model = "F-150 Raptor", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 31, Model = "F-150 Raptor R", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 32, Model = "Super Duty", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 33, Model = "E-Transit", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 34, Model = "Transit Connect", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 35, Model = "Escape", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 36, Model = "Edge", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 37, Model = "Bronco", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 38, Model = "Bronco Sport", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 39, Model = "Mustang Mach-E", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 40, Model = "Explorer", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 41, Model = "Expedition", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 42, Model = "Escort", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 43, Model = "Fiesta", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 44, Model = "Focus", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 45, Model = "Mondeo", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 46, Model = "F-250", VehicleMakeForeignKey = 2 },
                new VehicleModels { Id = 47, Model = "F-350", VehicleMakeForeignKey = 2 }
            );

            //Seed Vehicle data
            //modelBuilder_.Entity<Vehicle>().HasData(
            //   new Vehicle { Id = 1, CityFuelEconomy = 11, HighwayFuelEconomy = 8.9F, ModelForeignKeyId = 17, ListPrice = 45000.00F, SoldPrice = 45000.00F, DealerForeignKey = 2, Notes = "Low Mileage for the age. Purchased in 2023 with 19000Kms on the clock!", Color="White" }  

           //);

        }

        public DbSet<Dealer> Dealer {get; set;}

        public DbSet<VehicleMakes> VehicleMakes {get; set;}

        public DbSet<VehicleModels> VehicleModels {get; set;}

        public DbSet<Vehicle> Vehicles {get; set;}

        public DbSet<Picture> VehiclePictures {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder_)
        {
            base.OnConfiguring(optionsBuilder_);
            //var connectionString = _config["ConnectionStrings:VehicleContextConnection"];
            //optionsBuilder_.UseSqlServer(_config["ConnectionStrings:VehicleContextConnection"]);
            var secretPath = Environment.GetEnvironmentVariable("ConnectionStrings__VehicleContextConnection");
            if (File.Exists(secretPath))
            {
                var connectionString = File.ReadAllText(secretPath);
                Console.WriteLine($"Connection String: {connectionString}"); // Log the connection string
                optionsBuilder_.UseSqlServer(connectionString);
            }
            else
            {
                throw new FileNotFoundException($"Secret file not found: {secretPath}");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder_)
        {
            modelBuilder_.Entity<VehicleModels>()
            .HasOne(p => p.Make)
            .WithMany(b => b.Models)
            .HasForeignKey(p => p.VehicleMakeForeignKey)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder_.Entity<City>()
            .HasOne(p => p.Country)
            .WithMany(b => b.Cities)
            .HasForeignKey(p => p.CountryForeignKey)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder_.Entity<Dealer>()
            .HasOne(p => p.City)
            .WithMany(b => b.Dealerships)
            .HasForeignKey(p => p.CityForeignKey)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

            SeedData(modelBuilder_);
           
        }

    }
}