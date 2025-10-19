using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using RentACar.Application.Repositories;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Repositories
{
    public class CityRepository : RepositoryBase<City, Guid, RentACarDbContext>, ICityRepository
    {
        public CityRepository(RentACarDbContext context) : base(context)
        {
        }
    }
}
