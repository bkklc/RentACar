using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Door : BaseEntity<Guid>
    {       
        public string DoorCount { get; set; }
    }
}
