using Corp.Prod.BusinessLogic.Interfaces;
using Corp.Prod.BusinessLogic.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using FluentValidation.Results;
using Corp.Prod.BusinessLogic.Entities;

namespace Corp.Prod.BusinessLogic
{
    public class HopArrivalsLogic : IHopArrivalsLogic
    {
        HopArrival hopArrival { get; set; }
        public HopArrivalsLogic()
        {
            HopArrivalValidator validator = new();
            ValidationResult result = validator.Validate(hopArrival);
        }
    }
}
