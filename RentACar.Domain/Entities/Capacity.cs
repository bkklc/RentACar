using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Capacity : BaseEntity<Guid>
    {
        
        public string CapacityCount { get; set; }
    }
}
