using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Repositories
{
    public class YearRepository : RepositoryBase<Year, Guid, RentACarDbContext>
    {
        public YearRepository(RentACarDbContext context) : base(context)
        {

        }
    }
}
