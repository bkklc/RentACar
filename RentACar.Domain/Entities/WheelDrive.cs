using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class WheelDrive : Entity<Guid>
    {        
        public string WheelDriveType { get; set; }
    }
}
