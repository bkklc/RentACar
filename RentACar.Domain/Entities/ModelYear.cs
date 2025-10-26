using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class ModelYear : BaseEntity<Guid>
    {       
        public int Year { get; set; }
        public List<Car> Cars { get; set; } = new();
    }
}
