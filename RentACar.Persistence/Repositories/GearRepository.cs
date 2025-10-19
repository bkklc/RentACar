using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using RentACar.Domain.Repositories;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Repositories
{
    public class GearRepository : RepositoryBase<Gear, Guid, RentACarDbContext>, IGearRepository
    {
        public GearRepository(RentACarDbContext context) : base(context)
        {

        }
    
    }
}
