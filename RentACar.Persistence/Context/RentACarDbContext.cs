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
        {

        }

        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
