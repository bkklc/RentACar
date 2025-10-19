using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using RentACar.Domain.Repositories;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Repositories
{
    public class FuelTypeRepository : RepositoryBase<FuelType, Guid, RentACarDbContext>, IFuelTypeRepository
    {
        public FuelTypeRepository(RentACarDbContext context) : base(context)
        {

        }
    }
}
