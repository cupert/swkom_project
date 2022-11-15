using Corp.Prod.BusinessLogic.Entities;
using Corp.Prod.BusinessLogic.Interfaces;
using Corp.Prod.BusinessLogic.Validation;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Corp.Prod.DataAccess.Interfaces;

namespace Corp.Prod.BusinessLogic
{
    public class ParcelLogic : IParcelLogic
    {
        Parcel _parcel { get; set; }
        IMapper _mapper;
        IParcelRepository _repo;

        public ParcelLogic(IMapper mapper, IParcelRepository repo)
        {
            _repo = repo;
            _mapper = mapper;

            ParcelValidator validator = new();
            ValidationResult result = validator.Validate(_parcel);
        }

        public void UpdateParcel()
        {
            DataAccess.Entities.Parcel p = _mapper.Map<DataAccess.Entities.Parcel>(_parcel);
            _repo.Update(p);
        }

    }
}
