using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Corp.Prod.BusinessLogic.Entities;
using Microsoft.VisualBasic;

namespace Corp.Prod.Area.Sub.DTOs
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<GeoCoordinate, BusinessLogic.Entities.GeoCoordinate>()
                .ReverseMap();

            CreateMap<Hop, BusinessLogic.Entities.Hop>()
                .Include<Transferwarehouse, BusinessLogic.Entities.Transferwarehouse>()
                .Include<Truck, BusinessLogic.Entities.Truck>()
                .Include<Warehouse, BusinessLogic.Entities.Warehouse>()
                .ReverseMap();

            CreateMap<Transferwarehouse, BusinessLogic.Entities.Transferwarehouse>()
                .ReverseMap();

            CreateMap<Truck, BusinessLogic.Entities.Truck>()
                .ReverseMap();

            CreateMap<Warehouse, BusinessLogic.Entities.Warehouse>()
                .ReverseMap();

            CreateMap<HopArrival, BusinessLogic.Entities.HopArrival>()
                .ReverseMap();

            CreateMap<Parcel, BusinessLogic.Entities.Parcel>()
                .ForMember(destinationMember => destinationMember.Recipient, opt => opt.MapFrom(src => src.Recipient))
                .ForMember(destinationMember => destinationMember.Weight, opt => opt.MapFrom(src => src.Weight))
                .ForMember(destinationMember => destinationMember.Sender, opt => opt.MapFrom(src => src.Sender))
                .ReverseMap();

            CreateMap<NewParcelInfo, BusinessLogic.Entities.Parcel>()
                .ForMember(destinationMember => destinationMember.TrackingId, opt => opt.MapFrom(src => src.TrackingId))
                .ReverseMap();

            CreateMap<TrackingInformation, BusinessLogic.Entities.Parcel>()
                .ForMember(destinationMember => destinationMember.State, opt => opt.MapFrom(src => src.State))
                .ForMember(destinationMember => destinationMember.VisitedHops, opt => opt.MapFrom(src => src.VisitedHops))
                .ForMember(destinationMember => destinationMember.FutureHops, opt => opt.MapFrom(src => src.FutureHops))
                .ReverseMap();

            CreateMap<Recipient, BusinessLogic.Entities.Recipient>()
                .ReverseMap();           

            CreateMap<WarehouseNextHops, BusinessLogic.Entities.WarehouseNextHops>()
                .ReverseMap();

        }
    }
}
