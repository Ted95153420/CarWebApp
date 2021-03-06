﻿using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using CarPriceComparison.Services;
using CarPriceComparison.Models;
using AutoMapper;
using CarPriceComparison.ViewModels;
using CarPriceComparison.Resolvers;
using Microsoft.Extensions.Logging;

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

            services.AddAutoMapper(typeof(Startup));

            services.AddLogging(loggingBuilder => 
            {
                loggingBuilder.AddConsole();
                loggingBuilder.AddDebug();
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //very usefule reference - http://docs.automapper.org/en/stable/Custom-value-resolvers.html
            app.UseStaticFiles();
            
            Mapper.Initialize(cfg =>
                cfg.AddProfiles(new [] {"CarPriceComparison"})
            ); 
            
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
