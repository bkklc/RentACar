using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Repositories
{
    public class SerieRepository : RepositoryBase<Serie, Guid, RentACarDbContext>
    {
        public SerieRepository(RentACarDbContext context) : base(context)
        {

        }
    }
}
