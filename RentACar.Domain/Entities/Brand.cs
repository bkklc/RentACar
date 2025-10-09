using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Brand : Entity<Guid>
    {        
        public string Name { get; set; }
    }
}
