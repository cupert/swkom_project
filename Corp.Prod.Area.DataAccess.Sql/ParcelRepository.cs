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
    public class ParcelRepository : IParcelRepository
    {
        private readonly ILogger<ParcelRepository> _logger;

        public ParcelRepository(ILogger<ParcelRepository> logger)
        {
            _logger = logger;
        }

        public Parcel Create(Parcel p)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Parcel GetByTrackingId(string trackingid)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Parcel> GetByXX(string xx)
        {
            throw new NotImplementedException();
        }

        public Parcel GetByYY(int yy)
        {
            throw new NotImplementedException();
        }

        public Parcel Update(Parcel p)
        {
            throw new NotImplementedException();
        }
    }
}
