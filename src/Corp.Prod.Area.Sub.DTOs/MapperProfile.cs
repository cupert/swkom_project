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
            CreateMap<GeoCoordinate, Corp.Prod.BusinessLogic.Entities.GeoCoordinate>()
                .ReverseMap();

            CreateMap<Hop, Prod.BusinessLogic.Entities.Hop>()
                .Include<Transferwarehouse, Prod.BusinessLogic.Entities.Transferwarehouse>()
                .Include<Truck, Prod.BusinessLogic.Entities.Truck>()
                .Include<Warehouse, Prod.BusinessLogic.Entities.Warehouse>()
                .ReverseMap();

            CreateMap<Transferwarehouse, Prod.BusinessLogic.Entities.Transferwarehouse>()
                .ReverseMap();

            CreateMap<Truck, Prod.BusinessLogic.Entities.Truck>()
                .ReverseMap();

            CreateMap<Warehouse, Prod.BusinessLogic.Entities.Warehouse>()
                .ReverseMap();

            CreateMap<HopArrival, Prod.BusinessLogic.Entities.HopArrival>()
                .ReverseMap();

            CreateMap<Parcel, Prod.BusinessLogic.Entities.Parcel>()
                .ForMember(destinationMember => destinationMember.Recipient, opt => opt.MapFrom(src => src.Recipient))
                .ForMember(destinationMember => destinationMember.Weight, opt => opt.MapFrom(src => src.Weight))
                .ForMember(destinationMember => destinationMember.Sender, opt => opt.MapFrom(src => src.Sender))
                .ForMember(destinationMember => destinationMember.TrackingId, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.State, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.VisitedHops, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.FutureHops, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<NewParcelInfo, Prod.BusinessLogic.Entities.Parcel>()
                .ForMember(destinationMember => destinationMember.TrackingId, opt => opt.MapFrom(src => src.TrackingId))
                .ForMember(destinationMember => destinationMember.Recipient, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.Weight, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.Sender, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.State, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.VisitedHops, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.FutureHops, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<TrackingInformation, Prod.BusinessLogic.Entities.Parcel>()
                .ForMember(destinationMember => destinationMember.State, opt => opt.MapFrom(src => src.State))
                .ForMember(destinationMember => destinationMember.VisitedHops, opt => opt.MapFrom(src => src.VisitedHops))
                .ForMember(destinationMember => destinationMember.FutureHops, opt => opt.MapFrom(src => src.FutureHops))
                .ForMember(destinationMember => destinationMember.Recipient, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.Weight, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.Sender, opt => opt.Ignore())
                .ForMember(destinationMember => destinationMember.TrackingId, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<Recipient, Prod.BusinessLogic.Entities.Recipient>()
                .ReverseMap();           

            CreateMap<WarehouseNextHops, Prod.BusinessLogic.Entities.WarehouseNextHops>()
                .ReverseMap();



        }
    }
}
