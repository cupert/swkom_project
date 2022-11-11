using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Corp.Prod.Area.BusinessLogic.Entities.Converters;
using Corp.Prod.DataAccess.Entities;

namespace Corp.Prod.BusinessLogic.Entities
{
    internal class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Hop, DataAccess.Entities.Hop>()
                .ForMember(d => d.LocationCoordinates, opt => opt.ConvertUsing(new GeoPointConverter(), src => src.LocationCoordinates));
        }
    }
}
