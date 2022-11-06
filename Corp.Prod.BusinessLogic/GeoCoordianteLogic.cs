using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.BusinessLogic.Interfaces;

namespace Corp.Prod.BusinessLogic
{
    public class GeoCoordianteLogic : IGeoCoordinateLogic
    {
        public double testFunction(double lat)
        {
            if (double.IsNaN(lat))
            {
                return 0.0;
            }
            else
            {
                return lat;
            }
        }
    }
}
