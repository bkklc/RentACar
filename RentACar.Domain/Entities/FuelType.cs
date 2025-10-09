using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class FuelType : Entity<Guid>
    {        
        public string Fuel { get; set; }
    }
}
