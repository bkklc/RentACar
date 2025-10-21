using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Interfaces.Repositories
{
    public interface IColorRepository : IRepository<Color, Guid>
    {

    }
}
