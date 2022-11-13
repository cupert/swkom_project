using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.BusinessLogic.Entities;

namespace Corp.Prod.BusinessLogic.Test
{
    public class MapperTests
    {
        [Fact]
        public void MapperConfigurationVaildation_BusinessToDataAccess()
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MapperProfile>();
            });
            configuration.AssertConfigurationIsValid();
        }
    }
}
