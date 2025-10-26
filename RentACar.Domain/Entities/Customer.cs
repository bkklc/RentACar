using RentACar.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Domain.Entities
{
    public class Customer : BaseEntity<Guid>
    {           
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }               
        public DateTime? DriverLicenseDate { get; set; }

        public List<CustomerAddress> Addresses { get; set; } = new();
        public List<Rental> Rentals { get; set; } = new();

    }
}
