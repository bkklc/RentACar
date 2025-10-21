using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Interfaces.Repositories
{
    public interface ICityRepository : IRepository<City, Guid>
    {

    }
}
