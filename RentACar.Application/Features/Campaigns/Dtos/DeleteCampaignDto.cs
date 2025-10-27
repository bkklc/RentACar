using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Campaigns.Dtos
{
    public class DeleteCampaignDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime DeletedDate { get; set; }
    }
}
