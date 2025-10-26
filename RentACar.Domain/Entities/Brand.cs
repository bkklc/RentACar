using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Brand : BaseEntity<Guid>
    {        
        public string Name { get; set; }
        public List<Model> Models { get; set; } = new();
        public List<Car> Cars { get; set; } = new();
    }
}
