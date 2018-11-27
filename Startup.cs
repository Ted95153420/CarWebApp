using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CarPriceComparison.Services;
using CarPriceComparison.Models;

namespace CarPriceComparison
{
    public class Startup
    {
        private IConfigurationRoot _config;
        private IHostingEnvironment _env;

        public Startup(IConfiguration configuration, IHostingEnvironment env_)
        {
            _env = env_;
            Configuration = configuration;
            var builder = new ConfigurationBuilder()
                .SetBasePath(_env.ContentRootPath)
                .AddJsonFile("config.json")
                .AddEnvironmentVariables();
                
            _config = builder.Build();
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddSingleton(_config);
            //TO DO - understand the difference between AddTransient, AddScoped
            //and AddSingleton
            services.AddScoped<IMailService, DebugMailService>();

            //register the DbContext
            services.AddDbContext<VehicleContext>();

            services.AddScoped<IVehicleRepository, VehicleRepository>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseStaticFiles();

            app.UseMvc( config =>{
                config.MapRoute(
                    name    : "Default",
                    template: "{controller}/{action}/{id?}",
                    defaults: new {controller = "Home", action = "Index"}
                );
            });
         }
    }
}
