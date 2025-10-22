using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class FuelType : BaseEntity<Guid>
    {        
        public string Name { get; set; }
    }
}
