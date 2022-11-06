using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using Corp.Prod.BusinessLogic.Entities;

namespace Corp.Prod.BusinessLogic.Validation
{
    internal class HopArrivalValidator : AbstractValidator<HopArrival>
    {
        //regex aus hoparrival DTO
        public HopArrivalValidator()
        {
            RuleFor(hoparrival => hoparrival.Code).Matches(@"^[A-Z]{4}\\d{1,4}$");
        }
    }
}
