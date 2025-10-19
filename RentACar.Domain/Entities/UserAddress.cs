using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class UserAddress : BaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CityId { get; set; }
        public Guid CountryId { get; set; }
        public string AddressLine { get; set; }
        public string PostalCode { get; set; }
        
       
    }
}
