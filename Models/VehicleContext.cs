using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarPriceComparison.Models
{
    public class VehicleContext : DbContext
    {
        private IConfigurationRoot _config;
        public VehicleContext(IConfigurationRoot config_)
        {
            _config = config_;    
        }

        public DbSet<VehicleMake> VehicleMakes {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config[""]);    
        }
    }
}