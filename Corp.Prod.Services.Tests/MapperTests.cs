using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Corp.Prod.Area.Sub.Tests
{
    internal class MapperTests
    {
        [Test]
        public void MapperConfigurationVaildation_ServiceToBusiness()
        {

            var configuration = new MapperConfiguration(cfg => { 
                cfg.AddProfile<DTOs.MapperProfile>();
            });

            IMapper mapper = new Mapper(configuration);
            mapper.ConfigurationProvider.AssertConfigurationIsValid();
        }
    }
}
