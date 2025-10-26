using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Application.Features.Campaigns.Dtos
{
    public class CreateCampaignDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int? MinRentalDays { get; set; }
        public int? MaxRentalDays { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
