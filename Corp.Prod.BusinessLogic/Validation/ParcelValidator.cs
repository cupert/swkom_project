using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Corp.Prod.BusinessLogic.Entities;
using FluentValidation;

namespace Corp.Prod.BusinessLogic.Validation
{
    internal class ParcelValidator : AbstractValidator<Parcel>
    {
        public ParcelValidator()
        {
            RuleFor(parcel => parcel.Weight).GreaterThan(0);
            RuleFor(parcel => parcel.TrackingId).Matches(@"^[A-Z0-9]{9}$");
        }
    }
}
