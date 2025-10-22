using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class SeatCapacity : BaseEntity<Guid>
    {
        
        public int SeatCount { get; set; }
    }
}
