using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class CustomerAddress : BaseEntity<Guid>
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid CityId { get; set; }
        public Guid CountryId { get; set; }
        public string AddressLine { get; set; }
        public string PostalCode { get; set; }

        public Customer Customer { get; set; }
        public City City { get; set; }
        public Country Country { get; set; }


    }
}
