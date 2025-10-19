using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer, Guid>         
    {

    }
}
