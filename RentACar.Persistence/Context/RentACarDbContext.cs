using Microsoft.EntityFrameworkCore;
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
        }
    }
}
