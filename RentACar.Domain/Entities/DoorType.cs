using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class DoorType : BaseEntity<Guid>
    {       
        public int DoorCount { get; set; }
    }
}
