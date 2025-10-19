using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Repositories
{
    public interface IUserAddressRepository : IRepository<UserAddress, Guid>
    {

    }
}
