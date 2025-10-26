using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class GearType : BaseEntity<Guid>
    {        
        public string Name { get; set; }
        public List<Car> Cars { get; set; } = new();
    }
}
