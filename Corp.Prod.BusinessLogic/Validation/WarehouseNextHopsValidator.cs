using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.BusinessLogic.Entities;
using FluentValidation;

namespace Corp.Prod.BusinessLogic.Validation
{
    internal class WarehouseNextHopsValidator : AbstractValidator<WarehouseNextHops>
    {
        public WarehouseNextHopsValidator()
        {
            RuleFor(warehousenexthops => warehousenexthops.Hop).NotNull();
        }
    }
}
