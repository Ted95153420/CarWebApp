﻿// <auto-generated />
using System;
using CarPriceComparison.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CarPriceComparison.Migrations
{
    [DbContext(typeof(VehicleContext))]
    [Migration("20181229000428_Country_city_Dealership_Tidied_VehicleTable")]
    partial class Country_city_Dealership_Tidied_VehicleTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CarPriceComparison.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CityName");

                    b.Property<int>("CountryForeignKey");

                    b.HasKey("Id");

                    b.HasIndex("CountryForeignKey");

                    b.ToTable("City");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CityForeignKey");

                    b.Property<string>("DealerName");

                    b.Property<string>("PhoneNumber");

                    b.Property<string>("PostalCode");

                    b.Property<string>("StreetAddress");

                    b.Property<string>("WebAddress");

                    b.HasKey("Id");

                    b.HasIndex("CityForeignKey");

                    b.ToTable("Dealer");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CityFuelEconomy");

                    b.Property<string>("Color");

                    b.Property<float>("HighwayFuelEconomy");

                    b.Property<float>("ListPrice");

                    b.Property<string>("Notes");

                    b.Property<float>("SoldPrice");

                    b.Property<int?>("VehicleDealerId");

                    b.Property<int?>("VehicleMakeId");

                    b.Property<int?>("VehicleModelId");

                    b.HasKey("Id");

                    b.HasIndex("VehicleDealerId");

                    b.HasIndex("VehicleMakeId");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("Vehicle");
                });

            modelBuilder.Entity("CarPriceComparison.Models.VehicleMake", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Make");

                    b.HasKey("Id");

                    b.ToTable("VehicleMakes");
                });

            modelBuilder.Entity("CarPriceComparison.Models.VehicleModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Model");

                    b.Property<int>("VehicleMakeForeignKey");

                    b.HasKey("Id");

                    b.HasIndex("VehicleMakeForeignKey");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("CarPriceComparison.Models.City", b =>
                {
                    b.HasOne("CarPriceComparison.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryForeignKey")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarPriceComparison.Models.Dealer", b =>
                {
                    b.HasOne("CarPriceComparison.Models.City", "City")
                        .WithMany("Dealerships")
                        .HasForeignKey("CityForeignKey")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CarPriceComparison.Models.Vehicle", b =>
                {
                    b.HasOne("CarPriceComparison.Models.Dealer", "DealerForeignKey")
                        .WithMany("Vehicles")
                        .HasForeignKey("VehicleDealerId");

                    b.HasOne("CarPriceComparison.Models.VehicleMake", "MakeForeignKey")
                        .WithMany()
                        .HasForeignKey("VehicleMakeId");

                    b.HasOne("CarPriceComparison.Models.VehicleModel", "ModelForeignKey")
                        .WithMany()
                        .HasForeignKey("VehicleModelId");
                });

            modelBuilder.Entity("CarPriceComparison.Models.VehicleModel", b =>
                {
                    b.HasOne("CarPriceComparison.Models.VehicleMake", "Make")
                        .WithMany("Models")
                        .HasForeignKey("VehicleMakeForeignKey")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}