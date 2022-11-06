using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.BusinessLogic.Entities;
using Corp.Prod.BusinessLogic.Interfaces;
using Corp.Prod.BusinessLogic.Validation;
using FluentValidation.Results;

namespace Corp.Prod.BusinessLogic
{
    public class WarehouseNextHopLogic : IWarehouseNextHopsLogic
    {
        WarehouseNextHops warehouseNextHops { get; set; }
        public WarehouseNextHopLogic()
        {
            WarehouseNextHopsValidator validator = new();
            ValidationResult result = validator.Validate(warehouseNextHops);
        }
    }
}
