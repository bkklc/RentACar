using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class City : BaseEntity<Guid>
    {        
        public string Name { get; set; }

        public List<CustomerAddress> Addresses { get; set; } = new();
    }
}
