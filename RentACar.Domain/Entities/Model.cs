using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Model : Entity<Guid>
    {        
        public Guid SerieId { get; set; }
        public string Name { get; set; }
    }
}
