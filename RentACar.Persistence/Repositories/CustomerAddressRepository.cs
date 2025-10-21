using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;
using RentACar.Application.Interfaces.Repositories;

namespace RentACar.Persistence.Repositories
{
    public class CustomerAddressRepository : RepositoryBase<CustomerAddress, Guid, RentACarDbContext>, ICustomerAddressRepository
    {
        public CustomerAddressRepository(RentACarDbContext context) : base(context)
        {

        }
    }
}
