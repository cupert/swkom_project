using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.BusinessLogic.Interfaces;


namespace Corp.Prod.BusinessLogic
{
    public class TranferWarehouseLogic : ITransfarewarehouseLogic
    {
        public bool testFunction(string statement) 
        {
            if (statement == "LogisticsPartnet")  return true; 
            else return false;
        }
    }
}
