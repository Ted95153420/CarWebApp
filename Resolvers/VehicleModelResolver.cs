using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;
using System.Linq;

namespace CarPriceComparison.Resolvers
{
    public class VehicleModelResolver : IValueResolver<VehicleViewModel, Vehicle, VehicleModels>
    {
        private IVehicleRepository _vehicleRepo;
        public VehicleModelResolver(IVehicleRepository vehicleRepo_)
        {
            _vehicleRepo = vehicleRepo_;
        }

        public VehicleModels Resolve(VehicleViewModel source, Vehicle destination, VehicleModels destMember, ResolutionContext context)
        {
            List<VehicleModels> vehModels = _vehicleRepo.GetModelById(source.ModelForeignKey).ToList();
            return vehModels.FirstOrDefault();
        }
    }
}