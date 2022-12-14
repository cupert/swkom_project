using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.DataAccess.Entities;

namespace Corp.Prod.DataAccess.Interfaces
{
    public interface IParcelRepository
    {
        Parcel Create(Parcel p);
        Parcel Update(Parcel p);
        void Delete(int id);

        // Example with multiple GETs
        IEnumerable<Parcel> GetByXX(string xx);
        Parcel GetByYY(int yy);

        // Get by ID
        Parcel GetByTrackingId(string trackingid);        
    }
}
