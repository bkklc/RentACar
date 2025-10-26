using Microsoft.EntityFrameworkCore;
using RentACar.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RentACar.Persistence.Context
{
    public class RentACarDbContext : DbContext
    {
        public RentACarDbContext(DbContextOptions<RentACarDbContext> options) : base(options)
        {        }

        public DbSet<Brand> Brands { get; set; }
        public DbSet<BodyType> BodyTypes { get; set; }
        public DbSet<Campaign> Campaigns { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Country> Countries { get; set; }        
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        public DbSet<DoorType> DoorTypes { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<GearType> GearTypes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<ModelYear> ModelYears { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<SeatCapacity> SeatCapacities { get; set; }
        public DbSet<Serie> Series { get; set; }
        public DbSet<WheelDriveType> WheelDriveTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(RentACarDbContext).Assembly);
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
