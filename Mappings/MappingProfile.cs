using AutoMapper;
using CarPriceComparison.Resolvers;
using CarPriceComparison.ViewModels;
using CarPriceComparison.Models;

namespace CarPriceComparison.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<PictureViewModel, Picture>()
                .ForMember(dest => dest.VehicleForeignKey, opt => opt.MapFrom<PictureResolver>()).ReverseMap();

            CreateMap<VehicleViewModel, Vehicle>()
                .ForMember(dest => dest.DealerForeignKey, opt => opt.MapFrom<DealerResolver>())
                .ForMember(dest => dest.ModelForeignKey, opt => opt.MapFrom<VehicleModelResolver>()).ReverseMap();
        }
    }
}