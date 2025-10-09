using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Door : Entity<Guid>
    {       
        public string DoorCount { get; set; }
    }
}
