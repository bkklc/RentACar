using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class WheelDriveTypes : BaseEntity<Guid>
    {        
        public string WheelDriveType { get; set; }
    }
}
