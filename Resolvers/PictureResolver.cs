using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;
using System.Linq;

namespace CarPriceComparison.Resolvers
{
    public class PictureResolver : IValueResolver<PictureViewModel, Picture, Vehicle>
    {
        private IVehicleRepository _vehicleRepo;
        public PictureResolver(IVehicleRepository vehicleRepo_)
        {
            _vehicleRepo = vehicleRepo_;
        }

        public Vehicle Resolve(PictureViewModel source, Picture destination, Vehicle destMember, ResolutionContext context)
        {
            //_vehicleRepo.GetVehicleById(source.)
            return _vehicleRepo.GetVehicleById(source.VehicleForeignKey);

        }
    }
}