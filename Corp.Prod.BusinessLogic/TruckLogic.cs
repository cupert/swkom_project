using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.BusinessLogic.Interfaces;


namespace Corp.Prod.BusinessLogic
{
    public class TruckLogic : ITruckLogic
    {
        public bool testFunction(string statement)
        {
            if(statement == "NumberPlate") return true;
            else return false;
        }
    }
}
