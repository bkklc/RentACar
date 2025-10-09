using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Year : Entity<Guid>
    {       
        public string YearName { get; set; }
    }
}
