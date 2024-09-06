using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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

            //Seed City data
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

        }

        public DbSet<Dealer> Dealer {get; set;}

        public DbSet<VehicleMakes> VehicleMakes {get; set;}

        public DbSet<VehicleModels> VehicleModels {get; set;}

        public DbSet<Vehicle> Vehicles {get; set;}

        public DbSet<Picture> VehiclePictures {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder_)
        {
            base.OnConfiguring(optionsBuilder_);
            optionsBuilder_.UseSqlServer(_config["ConnectionStrings:VehicleContextConnection"]);    
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