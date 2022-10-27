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
                .ReverseMap();

            CreateMap<HopArrival, BusinessLogic.Entities.HopArrival>()
                .ReverseMap();

            CreateMap<Parcel, BusinessLogic.Entities.Parcel>()
                .ReverseMap();

            CreateMap<TrackingInformation, BusinessLogic.Entities.Parcel>()
                .ReverseMap();

            CreateMap<Recipient, BusinessLogic.Entities.Recipient>()
                .ReverseMap();

            CreateMap<Transferwarehouse, BusinessLogic.Entities.Transferwarehouse>()
                .ReverseMap();

            CreateMap<Truck, BusinessLogic.Entities.Truck>()
                .ReverseMap();

            CreateMap<Warehouse, BusinessLogic.Entities.Warehouse>()
                .ReverseMap();

            CreateMap<WarehouseNextHops, BusinessLogic.Entities.WarehouseNextHops>()
                .ReverseMap();

        }
    }
}
