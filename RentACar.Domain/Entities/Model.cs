using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Model : BaseEntity<Guid>
    {        
        public Guid BrandId { get; set; }
        public string Name { get; set; }

        public Brand Brand { get; set; }
        public List<Serie> Series { get; set; } = new();
        public List<Car> Cars { get; set; } = new();
    }
}
