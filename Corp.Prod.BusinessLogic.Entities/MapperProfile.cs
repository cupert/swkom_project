using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Corp.Prod.Area.BusinessLogic.Entities.Converters;
using Corp.Prod.BusinessLogic.Entities.Converters;

namespace Corp.Prod.BusinessLogic.Entities
{
    internal class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Hop, DataAccess.Entities.Hop>()
                .ForMember(d => d.LocationCoordinates, opt => opt.ConvertUsing(new GeoPointConverter(), src => src.LocationCoordinates))
                .ReverseMap();

            CreateMap<HopArrival, DataAccess.Entities.HopArrival>()
                .ReverseMap();

            CreateMap<Parcel, DataAccess.Entities.Parcel>()
                .ReverseMap();

            CreateMap<Recipient, DataAccess.Entities.Recipient>()
                .ReverseMap();

            CreateMap<Transferwarehouse, DataAccess.Entities.Transferwarehouse>()
                .ForMember(d=>d.Region, opt =>opt.ConvertUsing(new GeoJsonConverter(), src=>src.RegionGeoJson))
                .ReverseMap();

            CreateMap<Truck, DataAccess.Entities.Truck>()
                .ForMember(d=>d.Region,opt=>opt.ConvertUsing(new GeoJsonConverter(),src=>src.RegionGeoJson))
                .ReverseMap();

            CreateMap<Warehouse, DataAccess.Entities.Warehouse>()
                .ReverseMap();

            CreateMap<WarehouseNextHops, DataAccess.Entities.WarehouseNextHops>()
                .ReverseMap();
        }
    }
}
