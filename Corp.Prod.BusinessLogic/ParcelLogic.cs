using Corp.Prod.BusinessLogic.Entities;
using Corp.Prod.BusinessLogic.Interfaces;
using Corp.Prod.BusinessLogic.Validation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corp.Prod.BusinessLogic
{
    public class ParcelLogic : IParcelLogic
    {
        Parcel parcel { get; set; }
        public ParcelLogic()
        {
            ParcelValidator validator = new();
            ValidationResult result = validator.Validate(parcel);
        }

    }
}
