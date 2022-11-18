using Corp.Prod.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Prod.DataAccess.Interfaces
{
    public interface IHopRepository 
    {
        Hop Create(Hop h);
        Hop Update(Hop h);
        void Delete(int id);

        Hop GetHopByCode(string code);
    }
}
