using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Campaign  : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal DiscountRate { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public int? MinRentalDays { get; set; }
        public int? MaxRentalDays { get; set; }

    }
}
