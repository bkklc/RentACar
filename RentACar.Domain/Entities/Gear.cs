using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Gear : Entity<Guid>
    {        
        public string GearType { get; set; }
    }
}
