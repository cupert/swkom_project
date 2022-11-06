using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.BusinessLogic.Entities;
using FluentValidation;

namespace Corp.Prod.BusinessLogic.Validation
{
    internal class HopValidator : AbstractValidator<Hop>
    {
        public HopValidator()
        {
            RuleFor(hop => hop.LocationCoordinates).NotNull();
            RuleFor(hoparrival => hoparrival.Description).Matches(@"^([A-Z][A-Z]|[a-z][a-z](\d{2})-(\d{2}))$");

        }
    }
}
