using Corp.Prod.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Prod.DataAccess.Interfaces
{
    public interface IWarehouseRepository
    {
        Warehouse Create(Warehouse warehouse);
        Warehouse Get(int id);
        Warehouse Update(Warehouse warehouse);
        void Delete(int id);
    }
}
