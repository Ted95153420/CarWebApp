using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AutoMapper;
using CarPriceComparison.Models;
using CarPriceComparison.ViewModels;
using System.Linq;

namespace CarPriceComparison.Resolvers
{
    public class DealerResolver : IValueResolver<VehicleViewModel, Vehicle, Dealer>
    {
        private IVehicleRepository _vehicleRepo;
        public DealerResolver(IVehicleRepository vehicleRepo_)
        {
            _vehicleRepo = vehicleRepo_;
        }

        public Dealer Resolve(VehicleViewModel source, Vehicle destination, Dealer destMember, ResolutionContext context)
        {
            List<Dealer> dealers = _vehicleRepo.GetDealerById(source.DealerForeignKey).ToList();
            return dealers.FirstOrDefault();
        }
    }
}