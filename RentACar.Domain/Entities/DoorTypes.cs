using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class DoorTypes : BaseEntity<Guid>
    {       
        public string DoorCount { get; set; }
    }
}
