using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Gear : BaseEntity<Guid>
    {        
        public string GearType { get; set; }
    }
}
