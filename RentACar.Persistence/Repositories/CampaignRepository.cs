using RentACar.Application.Interfaces.Repositories;
using RentACar.Core.Interfaces;
using RentACar.Domain.Entities;
using RentACar.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Repositories
{
    public class CampaignRepository : RepositoryBase<Campaign, Guid, RentACarDbContext>, ICampaignRepository
    {
        public CampaignRepository(RentACarDbContext context) : base(context)
        {
        }
    }
}
