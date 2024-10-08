﻿// <auto-generated />
using System;
using CarPriceComparison.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarPriceComparison.Migrations
{
    [DbContext(typeof(VehicleContext))]
    [Migration("20240906205530_CitySeeding")]
    partial class CitySeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CarPriceComparison.Models.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryForeignKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CountryForeignKey");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CityName = "Toronto",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 2,
                            CityName = "Montréal",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 3,
                            CityName = "Vancouver",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 4,
                            CityName = "Calgary",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 5,
                            CityName = "Ottowa",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 6,
                            CityName = "Edmonton",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 7,
                            CityName = "Mississauga",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 8,
                            CityName = "North York",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 9,
                            CityName = "Winnipeg",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 10,
                            CityName = "Québec City",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 11,
                            CityName = "Hamilton",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 12,
                            CityName = "Brampton",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 13,
                            CityName = "Kitchener",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 14,
                            CityName = "Surrey",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 15,
                            CityName = "Laval",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 16,
                            CityName = "Halifax",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 17,
                            CityName = "London",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 18,
                            CityName = "Victoria",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 19,
                            CityName = "Windsor",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 20,
                            CityName = "Oshowa",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 21,
                            CityName = "Gatineau",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 22,
                            CityName = "Vaughan",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 23,
                            CityName = "Longueuil",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 24,
                            CityName = "Burnaby",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 25,
                            CityName = "Ladner",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 26,
                            CityName = "Saskatoon",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 27,
                            CityName = "Barrie",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 28,
                            CityName = "Richmond",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 29,
                            CityName = "Regina",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 30,
                            CityName = "Oakville",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 31,
                            CityName = "Burlington",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 32,
                            CityName = "Greater Sudbury",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 33,
                            CityName = "Abbotsford",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 34,
                            CityName = "Saguenay",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 35,
                            CityName = "St Catherines",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 36,
                            CityName = "Sherbrooke",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 37,
                            CityName = "Lévis",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 38,
                            CityName = "Kelowna",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 39,
                            CityName = "Cambridge",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 40,
                            CityName = "Trois Rivières",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 41,
                            CityName = "Guelph",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 42,
                            CityName = "Coquitlam",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 43,
                            CityName = "Kingston",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 44,
                            CityName = "Chatham-Kent",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 45,
                            CityName = "Sydney",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 46,
                            CityName = "Delta",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 47,
                            CityName = "DartMouth",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 48,
                            CityName = "Thunder Bay",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 49,
                            CityName = "St John's",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 50,
                            CityName = "Waterloo",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 51,
                            CityName = "Terrebonne",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 52,
                            CityName = "Langley",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 53,
                            CityName = "Saint John",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 54,
                            CityName = "Pickering",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 55,
                            CityName = "Brantford",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 56,
                            CityName = "Moncton",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 57,
                            CityName = "Nanaimo",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 58,
                            CityName = "Sarnia",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 59,
                            CityName = "Niagra Falls",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 60,
                            CityName = "Saint-Laurent",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 61,
                            CityName = "Repentigny",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 62,
                            CityName = "Fort McMurray",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 63,
                            CityName = "Peterborough",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 64,
                            CityName = "Sault Ste. Marie",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 65,
                            CityName = "Kawartha Lakes",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 66,
                            CityName = "Red Deer",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 67,
                            CityName = "Saint-Jean-sur-Richelieu",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 68,
                            CityName = "Lethbridge",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 69,
                            CityName = "Maple Ridge",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 70,
                            CityName = "Brossard",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 71,
                            CityName = "Chilliwack",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 72,
                            CityName = "Kamloops",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 73,
                            CityName = "White Rock",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 74,
                            CityName = "Prince George",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 75,
                            CityName = "Medicine Hat",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 76,
                            CityName = "Norfolk County",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 77,
                            CityName = "Drummondville",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 78,
                            CityName = "New Westminster",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 79,
                            CityName = "St Albert",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 80,
                            CityName = "Sherwood Park",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 81,
                            CityName = "Saint-Jérôme",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 82,
                            CityName = "Jonquière",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 83,
                            CityName = "Granby",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 84,
                            CityName = "Fredericton",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 85,
                            CityName = "Welland",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 86,
                            CityName = "Saint-Hyacinthe",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 87,
                            CityName = "North Bay",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 88,
                            CityName = "Shawinigan",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 89,
                            CityName = "Dollard-Des Ormeaux",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 90,
                            CityName = "Belleville",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 91,
                            CityName = "Cornwall",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 92,
                            CityName = "North Vancouver",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 93,
                            CityName = "Vernon",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 94,
                            CityName = "Blainville",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 95,
                            CityName = "Haldimand County",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 96,
                            CityName = "Timmins",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 97,
                            CityName = "Châteauguay",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 98,
                            CityName = "Quinte West",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 99,
                            CityName = "Charlottetown",
                            CountryForeignKey = 1
                        },
                        new
                        {
                            Id = 100,
                            CityName = "Rimouski",
                            CountryForeignKey = 1
                        });
                });

            modelBuilder.Entity("CarPriceComparison.Models.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CountryName = "Canada"
                        });
                });

            modelBuilder.Entity("CarPriceComparison.Models.Dealer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CityForeignKey")
                        .HasColumnType("int");

                    b.Property<string>("DealerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WebAddress")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CityForeignKey");

                    b.ToTable("Dealer");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Picture", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<byte[]>("Image")
                        .HasColumnType("varbinary(max)");

                    b.Property<int?>("VehicleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleId");

                    b.ToTable("VehiclePictures");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<float>("CityFuelEconomy")
                        .HasColumnType("real");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("HighwayFuelEconomy")
                        .HasColumnType("real");

                    b.Property<float>("ListPrice")
                        .HasColumnType("real");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("SoldPrice")
                        .HasColumnType("real");

                    b.Property<int?>("VehicleDealerId")
                        .HasColumnType("int");

                    b.Property<int?>("VehicleModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleDealerId");

                    b.HasIndex("VehicleModelId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("CarPriceComparison.Models.VehicleMakes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Make")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("VehicleMakes");
                });

            modelBuilder.Entity("CarPriceComparison.Models.VehicleModels", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VehicleMakeForeignKey")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("VehicleMakeForeignKey");

                    b.ToTable("VehicleModels");
                });

            modelBuilder.Entity("CarPriceComparison.Models.City", b =>
                {
                    b.HasOne("CarPriceComparison.Models.Country", "Country")
                        .WithMany("Cities")
                        .HasForeignKey("CountryForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Dealer", b =>
                {
                    b.HasOne("CarPriceComparison.Models.City", "City")
                        .WithMany("Dealerships")
                        .HasForeignKey("CityForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Picture", b =>
                {
                    b.HasOne("CarPriceComparison.Models.Vehicle", "VehicleForeignKey")
                        .WithMany("Pictures")
                        .HasForeignKey("VehicleId");

                    b.Navigation("VehicleForeignKey");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Vehicle", b =>
                {
                    b.HasOne("CarPriceComparison.Models.Dealer", "DealerForeignKey")
                        .WithMany("Vehicle")
                        .HasForeignKey("VehicleDealerId");

                    b.HasOne("CarPriceComparison.Models.VehicleModels", "ModelForeignKey")
                        .WithMany()
                        .HasForeignKey("VehicleModelId");

                    b.Navigation("DealerForeignKey");

                    b.Navigation("ModelForeignKey");
                });

            modelBuilder.Entity("CarPriceComparison.Models.VehicleModels", b =>
                {
                    b.HasOne("CarPriceComparison.Models.VehicleMakes", "Make")
                        .WithMany("Models")
                        .HasForeignKey("VehicleMakeForeignKey")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Make");
                });

            modelBuilder.Entity("CarPriceComparison.Models.City", b =>
                {
                    b.Navigation("Dealerships");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Country", b =>
                {
                    b.Navigation("Cities");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Dealer", b =>
                {
                    b.Navigation("Vehicle");
                });

            modelBuilder.Entity("CarPriceComparison.Models.Vehicle", b =>
                {
                    b.Navigation("Pictures");
                });

            modelBuilder.Entity("CarPriceComparison.Models.VehicleMakes", b =>
                {
                    b.Navigation("Models");
                });
#pragma warning restore 612, 618
        }
    }
}
