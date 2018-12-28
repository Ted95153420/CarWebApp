using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarPriceComparison.Models
{
    public class VehicleContext : DbContext
    {
        private IConfigurationRoot _config;
        public VehicleContext(IConfigurationRoot config_, DbContextOptions options_) : base(options_)
        {
            _config = config_;    
        }

        public DbSet<VehicleMake> VehicleMakes {get; set;}

        public DbSet<VehicleModel> VehicleModels {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:VehicleContextConnection"]);    
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<VehicleModel>()
            .HasOne(p => p.Make)
            .WithMany(b => b.Models)
            .HasForeignKey(p => p.VehicleMakeForeignKey)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<City>()
            .HasOne(p => p.Country)
            .WithMany(b => b.Cities)
            .HasForeignKey(p => p.CountryForeignKey)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Dealer>()
            .HasOne(p => p.City)
            .WithMany(b => b.Dealerships)
            .HasForeignKey(p => p.CityForeignKey)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);
        }

    }
}