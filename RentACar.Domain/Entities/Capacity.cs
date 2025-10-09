using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Capacity : Entity<Guid>
    {
        
        public string CapacityCount { get; set; }
    }
}
