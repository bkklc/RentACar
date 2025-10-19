using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Serie : BaseEntity<Guid>
    {             
        public Guid BrandId { get; set; }
        public string Name { get; set; }
    }
}
