using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using RentACar.Domain.Repositories;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Repositories
{
    public class WheelDriveRepository : RepositoryBase<WheelDrive, Guid, RentACarDbContext>, IWheelDriveRepository
    {
        public WheelDriveRepository(RentACarDbContext context) : base(context)
        {

        }
    }
}
