using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Rental : BaseEntity<Guid>
    {
        public Guid CarId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? CampaignId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public DateTime? ActualReturnDate { get; set; }
        public decimal DailyPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public bool IsActive { get; set; }

        public Car Car { get; set; }
        public Customer Customer { get; set; }
        public Campaign Campaign { get; set; }

    }
}
