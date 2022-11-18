using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Corp.Prod.BusinessLogic.Entities;
using Corp.Prod.BusinessLogic.Interfaces;
using Corp.Prod.BusinessLogic.Validation;
using Corp.Prod.DataAccess.Interfaces;
using FluentValidation.Results;
using Microsoft.Extensions.Logging;

namespace Corp.Prod.BusinessLogic
{
    public class WarehouseLogic : IWarehouseLogic
    {
        Warehouse _warehouse { get; set; }
        IWarehouseRepository _repo;
        IMapper _mapper;
        ILogger<WarehouseLogic> _logger;
        public WarehouseLogic(IWarehouseRepository repo, IMapper mapper, ILogger<WarehouseLogic> logger)
        {
            _mapper = mapper;
            _repo = repo;
            _logger = logger;

            WarehouseValidator validator = new();
            ValidationResult result = validator.Validate(_warehouse);
        }

        public void SubmitWarehouse()
        {
            _logger.LogInformation($"Updating Parcel {_warehouse.Code}");
            DataAccess.Entities.Warehouse warehouse = _mapper.Map<DataAccess.Entities.Warehouse>(_warehouse);
            _repo.Update(warehouse);
        }
    }
}
