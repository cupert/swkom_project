using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Corp.Prod.BusinessLogic.Entities.Converters;

namespace Corp.Prod.BusinessLogic.Entities
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Hop, DataAccess.Entities.Hop>()
                .Include<Transferwarehouse, DataAccess.Entities.Transferwarehouse>()
                .Include<Warehouse, DataAccess.Entities.Warehouse>()
                .Include<Truck, DataAccess.Entities.Truck>()
                .ForMember(d => d.LocationCoordinates, opt => opt.ConvertUsing(new GeoPointConverter(), src => src.LocationCoordinates))
                .ReverseMap();

            CreateMap<HopArrival, DataAccess.Entities.HopArrival>()
                .ReverseMap();

            CreateMap<Parcel, DataAccess.Entities.Parcel>()
                .ForMember(d => d.Id, opt => opt.Ignore())
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
                .ForMember(d => d.Id, opt => opt.Ignore())
                .ReverseMap();

            CreateMap<WarehouseNextHops, DataAccess.Entities.WarehouseNextHops>()
                .ReverseMap();
        }
    }
}
