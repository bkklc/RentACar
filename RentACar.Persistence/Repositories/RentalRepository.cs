using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using RentACar.Domain.Repositories;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Repositories
{
    public class RentalRepository : RepositoryBase<Rental, Guid, RentACarDbContext>, IRentalRepository
    {
        public RentalRepository(RentACarDbContext context) : base(context)
        {

        }
    }
}
