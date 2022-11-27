using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.DataAccess.Entities;
using Corp.Prod.DataAccess.Interfaces;
using Microsoft.Extensions.Logging;

namespace Corp.Prod.DataAccess.Sql
{
    internal class WarehouseRepository : IWarehouseRepository
    {
        private readonly ILogger<WarehouseRepository> _logger;

        public WarehouseRepository(ILogger<WarehouseRepository> logger)
        {
            _logger = logger;
        }

        public Warehouse Create(Warehouse p)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Warehouse Get(int id)
        {
            throw new NotImplementedException();
        }

        public Warehouse Update(Warehouse p)
        {
            throw new NotImplementedException();
        }
    }
}
